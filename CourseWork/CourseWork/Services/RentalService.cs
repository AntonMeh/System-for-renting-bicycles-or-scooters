using CourseWork.Data;
using CourseWork.DTOs;
using CourseWork.Models;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace CourseWork.Services
{
    public class RentalService
    {
        private readonly AppDbContext _db;
        private static readonly GeometryFactory _gf = new(new PrecisionModel(), 4326);
        private const double MaxDistanceToRentalPoint = 50.0; // метрів

        public RentalService(AppDbContext db)
        {
            _db = db;
        }

        public async Task<RentalResult> StartRentalAsync(int clientId, int vehicleId)
        {
            var client = await _db.Clients.FindAsync(clientId);
            if (client == null)
                return Fail("Клієнта не знайдено.");

            if (client.Balance <= 0)
                return Fail("Недостатньо коштів на балансі.");

            var vehicle = await _db.Vehicles
                .Include(v => v.VehicleType)
                .FirstOrDefaultAsync(v => v.Id == vehicleId);

            if (vehicle == null)
                return Fail("Транспортний засіб не знайдено.");

            if (!vehicle.IsAvailable)
                return Fail("Транспортний засіб вже орендований.");

            // Знімаємо плату за розблокування одразу
            if (client.Balance < vehicle.VehicleType.UnlockFee)
                return Fail($"Недостатньо коштів для розблокування ({vehicle.VehicleType.UnlockFee} грн).");

            vehicle.IsAvailable = false;

            var rental = new Rental
            {
                ClientId = clientId,
                VehicleId = vehicleId,
                StartTime = DateTime.UtcNow,
                StartRentalPointId = vehicle.RentalPointId
            };

            vehicle.RentalPointId = null;

            _db.Rentals.Add(rental);
            await _db.SaveChangesAsync();

            return new RentalResult
            {
                Success = true,
                Message = "Оренду розпочато.",
                RentalId = rental.Id
            };
        }

        public async Task<RentalResult> EndRentalAsync(int rentalId, double endLatitude, double endLongitude)
        {
            var rental = await _db.Rentals
                .Include(r => r.Vehicle)
                    .ThenInclude(v => v.VehicleType)
                .Include(r => r.Client)
                .FirstOrDefaultAsync(r => r.Id == rentalId);

            if (rental == null)
                return Fail("Оренду не знайдено.");

            if (rental.EndTime != null)
                return Fail("Цю оренду вже завершено.");

            var endPoint = _gf.CreatePoint(new Coordinate(endLongitude, endLatitude));
            endPoint.SRID = 4326;

            // Гео-валідація: перевірка дозволеної GeoZone (не Restricted)
            var isInAllowedZone = await _db.GeoZones
                .AnyAsync(gz => gz.ZoneType != "Restricted" && gz.Boundary.Contains(endPoint));

            // Перевірка близькості до RentalPoint (< 50м)
            var isNearRentalPoint = await _db.RentalPoints
                .AnyAsync(rp => rp.Location.IsWithinDistance(endPoint, MaxDistanceToRentalPoint / 111_320.0));
            // ~111320м = 1 градус широти; грубе наближення для метрів → градуси

            if (!isInAllowedZone && !isNearRentalPoint)
                return Fail("Неможливо завершити оренду: транспорт поза дозволеною зоною та далеко від точок прокату.");

            // Завершення оренди
            rental.EndTime = DateTime.UtcNow;

            // Розрахунок вартості
            var minutes = (decimal)(rental.EndTime.Value - rental.StartTime).TotalMinutes;
            var unlockFee = rental.Vehicle.VehicleType.UnlockFee;
            var perMinute = rental.Vehicle.VehicleType.PerMinuteRate;
            var totalCost = unlockFee + Math.Ceiling(minutes) * perMinute;

            rental.TotalCost = totalCost;
            rental.Client.Balance -= totalCost;

            // Оновлення транспорту
            rental.Vehicle.CurrentLocation = endPoint;
            rental.Vehicle.IsAvailable = true;

            // Прив'язка до найближчого RentalPoint (якщо є поблизу)
            var nearestPoint = await _db.RentalPoints
                .OrderBy(rp => rp.Location.Distance(endPoint))
                .FirstOrDefaultAsync(rp => rp.Location.IsWithinDistance(endPoint, MaxDistanceToRentalPoint / 111_320.0));

            if (nearestPoint != null)
            {
                rental.Vehicle.RentalPointId = nearestPoint.Id;
                rental.EndRentalPointId = nearestPoint.Id;
            }

            await _db.SaveChangesAsync();

            return new RentalResult
            {
                Success = true,
                Message = $"Оренду завершено. Списано {totalCost:F2} грн.",
                RentalId = rental.Id,
                TotalCost = totalCost
            };
        }

        private static RentalResult Fail(string message) =>
            new() { Success = false, Message = message };
    }
}
