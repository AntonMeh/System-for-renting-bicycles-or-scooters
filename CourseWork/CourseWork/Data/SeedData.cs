using CourseWork.Models;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace CourseWork.Data
{
    public static class SeedData
    {
        private static readonly GeometryFactory _gf = new(new PrecisionModel(), 4326);

        private static Point P(double lon, double lat) => _gf.CreatePoint(new Coordinate(lon, lat));

        private static Polygon Box(double lonMin, double latMin, double lonMax, double latMax)
        {
            return _gf.CreatePolygon(new[]
            {
                new Coordinate(lonMin, latMin),
                new Coordinate(lonMax, latMin),
                new Coordinate(lonMax, latMax),
                new Coordinate(lonMin, latMax),
                new Coordinate(lonMin, latMin)
            });
        }

        public static void Seed(ModelBuilder mb)
        {
            SeedVehicleTypes(mb);
            SeedClients(mb);
            SeedRentalPoints(mb);
            SeedVehicles(mb);
            SeedRentals(mb);
            SeedGeoZones(mb);
        }

        private static void SeedVehicleTypes(ModelBuilder mb)
        {
            mb.Entity<VehicleType>().HasData(
                new { Id = 1,  Name = "Xiaomi Mi Pro 2",           Category = "Самокат",          UnlockFee = 15.00m, PerMinuteRate = 4.50m },
                new { Id = 2,  Name = "Xiaomi Mi Essential",       Category = "Самокат",          UnlockFee = 10.00m, PerMinuteRate = 3.50m },
                new { Id = 3,  Name = "Ninebot Max G30",           Category = "Самокат",          UnlockFee = 20.00m, PerMinuteRate = 5.00m },
                new { Id = 4,  Name = "Kugoo S3 Pro",              Category = "Самокат",          UnlockFee = 12.00m, PerMinuteRate = 3.80m },
                new { Id = 5,  Name = "Segway Ninebot E2",         Category = "Самокат",          UnlockFee = 10.00m, PerMinuteRate = 3.00m },
                new { Id = 6,  Name = "City Classic 28",           Category = "Велосипед",        UnlockFee = 5.00m,  PerMinuteRate = 2.00m },
                new { Id = 7,  Name = "Mountain Trail 29",         Category = "Велосипед",        UnlockFee = 8.00m,  PerMinuteRate = 2.50m },
                new { Id = 8,  Name = "E-Bike City Pro",           Category = "Електровелосипед", UnlockFee = 15.00m, PerMinuteRate = 4.00m },
                new { Id = 9,  Name = "Xiaomi Mi 1S",              Category = "Самокат",          UnlockFee = 12.00m, PerMinuteRate = 4.00m },
                new { Id = 10, Name = "Kugoo Kirin M4",            Category = "Самокат",          UnlockFee = 18.00m, PerMinuteRate = 5.50m },
                new { Id = 11, Name = "Fold Compact 20",           Category = "Велосипед",        UnlockFee = 6.00m,  PerMinuteRate = 2.20m },
                new { Id = 12, Name = "Ninebot F40",               Category = "Самокат",          UnlockFee = 16.00m, PerMinuteRate = 4.80m },
                new { Id = 13, Name = "E-Bike Cargo Max",          Category = "Електровелосипед", UnlockFee = 20.00m, PerMinuteRate = 5.00m },
                new { Id = 14, Name = "Segway P65",                Category = "Самокат",          UnlockFee = 25.00m, PerMinuteRate = 6.00m },
                new { Id = 15, Name = "Kugoo G-Booster",           Category = "Самокат",          UnlockFee = 22.00m, PerMinuteRate = 5.80m }
            );
        }

        private static void SeedClients(ModelBuilder mb)
        {
            mb.Entity<Client>().HasData(
                new { Id = 1,  LastName = "Шевченко",    FirstName = "Олександр",  Patronymic = "Петрович",     Phone = "+380501234567", Email = "shevchenko.o@gmail.com",  Balance = 250.00m },
                new { Id = 2,  LastName = "Коваленко",   FirstName = "Марія",     Patronymic = "Іванівна",     Phone = "+380672345678", Email = "kovalenko.m@ukr.net",     Balance = 180.50m },
                new { Id = 3,  LastName = "Бондаренко",  FirstName = "Андрій",    Patronymic = "Сергійович",   Phone = "+380933456789", Email = "bondarenko.a@gmail.com",  Balance = 320.00m },
                new { Id = 4,  LastName = "Ткаченко",    FirstName = "Ольга",     Patronymic = "Вікторівна",   Phone = "+380504567890", Email = "tkachenko.o@ukr.net",     Balance = 95.75m },
                new { Id = 5,  LastName = "Мельник",     FirstName = "Дмитро",    Patronymic = "Олегович",     Phone = "+380675678901", Email = "melnyk.d@gmail.com",      Balance = 410.00m },
                new { Id = 6,  LastName = "Кравченко",   FirstName = "Наталія",   Patronymic = "Юріївна",      Phone = "+380936789012", Email = "kravchenko.n@ukr.net",    Balance = 150.25m },
                new { Id = 7,  LastName = "Олійник",     FirstName = "Ігор",      Patronymic = "Васильович",   Phone = "+380507890123", Email = "oliinyk.i@gmail.com",     Balance = 200.00m },
                new { Id = 8,  LastName = "Поліщук",     FirstName = "Катерина",  Patronymic = "Андріївна",    Phone = "+380678901234", Email = "polishchuk.k@ukr.net",    Balance = 75.00m },
                new { Id = 9,  LastName = "Савченко",    FirstName = "Віталій",   Patronymic = "Миколайович",  Phone = "+380939012345", Email = "savchenko.v@gmail.com",   Balance = 560.00m },
                new { Id = 10, LastName = "Руденко",     FirstName = "Анна",      Patronymic = "Олександрівна",Phone = "+380500123456", Email = "rudenko.a@ukr.net",       Balance = 300.00m },
                new { Id = 11, LastName = "Литвиненко",  FirstName = "Сергій",    Patronymic = "Ігорович",     Phone = "+380671234509", Email = "lytvynenko.s@gmail.com",  Balance = 125.50m },
                new { Id = 12, LastName = "Мороз",       FirstName = "Юлія",      Patronymic = "Дмитрівна",    Phone = "+380932345610", Email = "moroz.y@ukr.net",         Balance = 440.00m },
                new { Id = 13, LastName = "Павленко",    FirstName = "Роман",     Patronymic = "Тарасович",    Phone = "+380503456711", Email = "pavlenko.r@gmail.com",    Balance = 88.00m },
                new { Id = 14, LastName = "Хоменко",     FirstName = "Ірина",     Patronymic = "Степанівна",   Phone = "+380674567812", Email = "khomenko.i@ukr.net",      Balance = 670.00m },
                new { Id = 15, LastName = "Гончаренко",  FirstName = "Максим",    Patronymic = "Павлович",     Phone = "+380935678913", Email = "honcharenko.m@gmail.com", Balance = 215.00m }
            );
        }

        private static void SeedRentalPoints(ModelBuilder mb)
        {
            // Черкаси: центр ~32.062 lon, 49.444 lat; Канів: центр ~31.461 lon, 49.752 lat
            mb.Entity<RentalPoint>().HasData(
                new { Id = 1,  Name = "Центр Черкаси",                  Address = "м. Черкаси, бул. Шевченка, 205",        Location = P(32.0621, 49.4445) },
                new { Id = 2,  Name = "Парк ім. 30-річчя Перемоги",     Address = "м. Черкаси, вул. Благовісна, 170",      Location = P(32.0530, 49.4380) },
                new { Id = 3,  Name = "Набережна Дніпра",               Address = "м. Черкаси, вул. Набережна, 1",         Location = P(32.0490, 49.4520) },
                new { Id = 4,  Name = "Район Митниця",                  Address = "м. Черкаси, вул. Героїв Дніпра, 45",    Location = P(32.0150, 49.4260) },
                new { Id = 5,  Name = "ТРЦ Любава",                     Address = "м. Черкаси, вул. Смілянська, 36",       Location = P(32.0580, 49.4400) },
                new { Id = 6,  Name = "Вокзал Черкаси",                  Address = "м. Черкаси, вул. Вокзальна, 1",         Location = P(32.0680, 49.4350) },
                new { Id = 7,  Name = "Парк Перемоги",                   Address = "м. Черкаси, вул. Хрещатик, 190",        Location = P(32.0550, 49.4470) },
                new { Id = 8,  Name = "Дахнівка",                        Address = "м. Черкаси, вул. Дахнівська, 12",        Location = P(32.0800, 49.4300) },
                new { Id = 9,  Name = "Район Соснівка",                  Address = "м. Черкаси, вул. Сумгаїтська, 28",      Location = P(32.0340, 49.4180) },
                new { Id = 10, Name = "Площа Б. Хмельницького",         Address = "м. Черкаси, пл. Б. Хмельницького, 1",   Location = P(32.0600, 49.4460) },
                new { Id = 11, Name = "Канів Центр",                     Address = "м. Канів, вул. Шевченка, 89",           Location = P(31.4610, 49.7520) },
                new { Id = 12, Name = "Тарасова гора",                   Address = "м. Канів, Тарасова гора, 1",            Location = P(31.4700, 49.7550) },
                new { Id = 13, Name = "Набережна Канева",                Address = "м. Канів, вул. Набережна, 5",           Location = P(31.4560, 49.7480) },
                new { Id = 14, Name = "Парк Канів",                      Address = "м. Канів, вул. Героїв, 34",             Location = P(31.4580, 49.7500) },
                new { Id = 15, Name = "Автостанція Канів",               Address = "м. Канів, вул. Київська, 70",           Location = P(31.4630, 49.7540) }
            );
        }

        private static void SeedVehicles(ModelBuilder mb)
        {
            mb.Entity<Vehicle>().HasData(
                new { Id = 1,  SerialNumber = "XM-PRO2-0001",  BatteryLevel = 95,  IsAvailable = true,  VehicleTypeId = 1,  RentalPointId = (int?)1,    CurrentLocation = P(32.0621, 49.4445) },
                new { Id = 2,  SerialNumber = "XM-ESS-0002",   BatteryLevel = 80,  IsAvailable = true,  VehicleTypeId = 2,  RentalPointId = (int?)1,    CurrentLocation = P(32.0623, 49.4446) },
                new { Id = 3,  SerialNumber = "NB-MAX-0003",   BatteryLevel = 60,  IsAvailable = false, VehicleTypeId = 3,  RentalPointId = (int?)null, CurrentLocation = P(32.0500, 49.4400) },
                new { Id = 4,  SerialNumber = "KG-S3P-0004",   BatteryLevel = 100, IsAvailable = true,  VehicleTypeId = 4,  RentalPointId = (int?)2,    CurrentLocation = P(32.0530, 49.4380) },
                new { Id = 5,  SerialNumber = "SG-E2-0005",    BatteryLevel = 45,  IsAvailable = true,  VehicleTypeId = 5,  RentalPointId = (int?)3,    CurrentLocation = P(32.0490, 49.4520) },
                new { Id = 6,  SerialNumber = "VL-CLS-0006",   BatteryLevel = 100, IsAvailable = true,  VehicleTypeId = 6,  RentalPointId = (int?)4,    CurrentLocation = P(32.0150, 49.4260) },
                new { Id = 7,  SerialNumber = "VL-TRL-0007",   BatteryLevel = 100, IsAvailable = false, VehicleTypeId = 7,  RentalPointId = (int?)null, CurrentLocation = P(32.0560, 49.4475) },
                new { Id = 8,  SerialNumber = "EV-CTE-0008",   BatteryLevel = 70,  IsAvailable = true,  VehicleTypeId = 8,  RentalPointId = (int?)5,    CurrentLocation = P(32.0580, 49.4400) },
                new { Id = 9,  SerialNumber = "XM-1S-0009",    BatteryLevel = 88,  IsAvailable = true,  VehicleTypeId = 9,  RentalPointId = (int?)6,    CurrentLocation = P(32.0680, 49.4350) },
                new { Id = 10, SerialNumber = "KG-M4-0010",    BatteryLevel = 55,  IsAvailable = true,  VehicleTypeId = 10, RentalPointId = (int?)7,    CurrentLocation = P(32.0550, 49.4470) },
                new { Id = 11, SerialNumber = "VL-FLD-0011",   BatteryLevel = 100, IsAvailable = true,  VehicleTypeId = 11, RentalPointId = (int?)11,   CurrentLocation = P(31.4610, 49.7520) },
                new { Id = 12, SerialNumber = "NB-F40-0012",   BatteryLevel = 30,  IsAvailable = false, VehicleTypeId = 12, RentalPointId = (int?)null, CurrentLocation = P(31.4650, 49.7510) },
                new { Id = 13, SerialNumber = "EV-CRG-0013",   BatteryLevel = 90,  IsAvailable = true,  VehicleTypeId = 13, RentalPointId = (int?)12,   CurrentLocation = P(31.4700, 49.7550) },
                new { Id = 14, SerialNumber = "SG-P65-0014",   BatteryLevel = 75,  IsAvailable = true,  VehicleTypeId = 14, RentalPointId = (int?)13,   CurrentLocation = P(31.4560, 49.7480) },
                new { Id = 15, SerialNumber = "KG-GBS-0015",   BatteryLevel = 20,  IsAvailable = true,  VehicleTypeId = 15, RentalPointId = (int?)14,   CurrentLocation = P(31.4580, 49.7500) }
            );
        }

        private static DateTime Utc(int y, int mo, int d, int h, int mi) => new(y, mo, d, h, mi, 0, DateTimeKind.Utc);

        private static void SeedRentals(ModelBuilder mb)
        {
            mb.Entity<Rental>().HasData(
                new { Id = 1,  ClientId = 1,  VehicleId = 1,  StartTime = Utc(2026,5,1,9,0),    EndTime = (DateTime?)Utc(2026,5,1,9,25),    TotalCost = (decimal?)127.50m,  StartRentalPointId = (int?)1,  EndRentalPointId = (int?)2 },
                new { Id = 2,  ClientId = 2,  VehicleId = 3,  StartTime = Utc(2026,5,1,10,30),   EndTime = (DateTime?)Utc(2026,5,1,11,0),    TotalCost = (decimal?)170.00m,  StartRentalPointId = (int?)2,  EndRentalPointId = (int?)5 },
                new { Id = 3,  ClientId = 3,  VehicleId = 5,  StartTime = Utc(2026,5,2,14,0),    EndTime = (DateTime?)Utc(2026,5,2,14,40),   TotalCost = (decimal?)130.00m,  StartRentalPointId = (int?)3,  EndRentalPointId = (int?)1 },
                new { Id = 4,  ClientId = 4,  VehicleId = 7,  StartTime = Utc(2026,5,2,16,0),    EndTime = (DateTime?)Utc(2026,5,2,17,0),    TotalCost = (decimal?)158.00m,  StartRentalPointId = (int?)7,  EndRentalPointId = (int?)4 },
                new { Id = 5,  ClientId = 5,  VehicleId = 2,  StartTime = Utc(2026,5,3,8,15),    EndTime = (DateTime?)Utc(2026,5,3,8,35),    TotalCost = (decimal?)80.00m,   StartRentalPointId = (int?)1,  EndRentalPointId = (int?)3 },
                new { Id = 6,  ClientId = 6,  VehicleId = 4,  StartTime = Utc(2026,5,3,11,0),    EndTime = (DateTime?)Utc(2026,5,3,11,45),   TotalCost = (decimal?)183.00m,  StartRentalPointId = (int?)2,  EndRentalPointId = (int?)6 },
                new { Id = 7,  ClientId = 7,  VehicleId = 6,  StartTime = Utc(2026,5,4,7,30),    EndTime = (DateTime?)Utc(2026,5,4,8,30),    TotalCost = (decimal?)125.00m,  StartRentalPointId = (int?)4,  EndRentalPointId = (int?)9 },
                new { Id = 8,  ClientId = 8,  VehicleId = 8,  StartTime = Utc(2026,5,4,13,0),    EndTime = (DateTime?)Utc(2026,5,4,13,20),   TotalCost = (decimal?)95.00m,   StartRentalPointId = (int?)5,  EndRentalPointId = (int?)7 },
                new { Id = 9,  ClientId = 9,  VehicleId = 10, StartTime = Utc(2026,5,5,9,0),     EndTime = (DateTime?)Utc(2026,5,5,9,50),    TotalCost = (decimal?)293.00m,  StartRentalPointId = (int?)7,  EndRentalPointId = (int?)10 },
                new { Id = 10, ClientId = 10, VehicleId = 9,  StartTime = Utc(2026,5,5,15,0),    EndTime = (DateTime?)Utc(2026,5,5,15,30),   TotalCost = (decimal?)132.00m,  StartRentalPointId = (int?)6,  EndRentalPointId = (int?)8 },
                new { Id = 11, ClientId = 11, VehicleId = 11, StartTime = Utc(2026,5,6,10,0),    EndTime = (DateTime?)Utc(2026,5,6,10,55),   TotalCost = (decimal?)127.00m,  StartRentalPointId = (int?)11, EndRentalPointId = (int?)13 },
                new { Id = 12, ClientId = 12, VehicleId = 12, StartTime = Utc(2026,5,6,12,0),    EndTime = (DateTime?)Utc(2026,5,6,12,15),   TotalCost = (decimal?)88.00m,   StartRentalPointId = (int?)11, EndRentalPointId = (int?)12 },
                new { Id = 13, ClientId = 13, VehicleId = 14, StartTime = Utc(2026,5,7,17,0),    EndTime = (DateTime?)Utc(2026,5,7,17,35),   TotalCost = (decimal?)235.00m,  StartRentalPointId = (int?)13, EndRentalPointId = (int?)14 },
                new { Id = 14, ClientId = 14, VehicleId = 13, StartTime = Utc(2026,5,8,8,0),     EndTime = (DateTime?)null,                  TotalCost = (decimal?)null,     StartRentalPointId = (int?)12, EndRentalPointId = (int?)null },
                new { Id = 15, ClientId = 15, VehicleId = 15, StartTime = Utc(2026,5,8,9,30),    EndTime = (DateTime?)null,                  TotalCost = (decimal?)null,     StartRentalPointId = (int?)14, EndRentalPointId = (int?)null }
            );
        }

        private static void SeedGeoZones(ModelBuilder mb)
        {
            // Черкаси: бул. Шевченка ~32.055-32.068, ~49.440-49.450
            // Канів: центр ~31.455-31.475, ~49.745-49.760
            mb.Entity<GeoZone>().HasData(
                new { Id = 1,  Name = "Центр Черкас",                ZoneType = "Allowed",      Description = "Центральна зона: бул. Шевченка — Хрещатик",     SpeedLimit = (double?)25.0,  Boundary = Box(32.0520, 49.4400, 32.0700, 49.4500) },
                new { Id = 2,  Name = "Набережна Дніпра",            ZoneType = "SpeedLimited", Description = "Набережна від мосту до річпорту",                 SpeedLimit = (double?)10.0,  Boundary = Box(32.0420, 49.4480, 32.0560, 49.4560) },
                new { Id = 3,  Name = "Парк 30-річчя Перемоги",      ZoneType = "SpeedLimited", Description = "Паркова зона між вул. Благовісна та Смілянська",  SpeedLimit = (double?)15.0,  Boundary = Box(32.0480, 49.4340, 32.0600, 49.4420) },
                new { Id = 4,  Name = "Район Митниця",               ZoneType = "Allowed",      Description = "Житловий масив Митниця",                         SpeedLimit = (double?)null,  Boundary = Box(32.0050, 49.4200, 32.0300, 49.4340) },
                new { Id = 5,  Name = "Промзона Придніпровська",     ZoneType = "Restricted",   Description = "Промислова зона — рух заборонено",               SpeedLimit = (double?)null,  Boundary = Box(32.0850, 49.4250, 32.1050, 49.4400) },
                new { Id = 6,  Name = "Район Соснівка",              ZoneType = "Allowed",      Description = "Мікрорайон Соснівка",                            SpeedLimit = (double?)null,  Boundary = Box(32.0250, 49.4100, 32.0450, 49.4250) },
                new { Id = 7,  Name = "Район Дахнівка",              ZoneType = "Allowed",      Description = "Мікрорайон Дахнівка",                            SpeedLimit = (double?)null,  Boundary = Box(32.0700, 49.4240, 32.0900, 49.4360) },
                new { Id = 8,  Name = "Паркінг ТРЦ Любава",          ZoneType = "Parking",      Description = "Зона паркування біля ТРЦ Любава",                SpeedLimit = (double?)5.0,   Boundary = Box(32.0565, 49.4390, 32.0600, 49.4415) },
                new { Id = 9,  Name = "Вокзальна площа",             ZoneType = "SpeedLimited", Description = "Привокзальна зона",                              SpeedLimit = (double?)10.0,  Boundary = Box(32.0640, 49.4320, 32.0720, 49.4380) },
                new { Id = 10, Name = "Хрещатик",                    ZoneType = "Allowed",      Description = "Вул. Хрещатик та прилеглі квартали",             SpeedLimit = (double?)20.0,  Boundary = Box(32.0500, 49.4440, 32.0620, 49.4510) },
                new { Id = 11, Name = "Канів Центр",                 ZoneType = "Allowed",      Description = "Центральна частина Канева",                      SpeedLimit = (double?)25.0,  Boundary = Box(31.4530, 49.7460, 31.4700, 49.7580) },
                new { Id = 12, Name = "Тарасова гора",               ZoneType = "SpeedLimited", Description = "Заповідна зона навколо могили Т. Шевченка",       SpeedLimit = (double?)10.0,  Boundary = Box(31.4650, 49.7520, 31.4780, 49.7600) },
                new { Id = 13, Name = "Набережна Канева",            ZoneType = "SpeedLimited", Description = "Набережна вздовж Дніпра",                        SpeedLimit = (double?)15.0,  Boundary = Box(31.4480, 49.7440, 31.4620, 49.7520) },
                new { Id = 14, Name = "Парк відпочинку Канів",       ZoneType = "Parking",      Description = "Зона паркування у міському парку",               SpeedLimit = (double?)5.0,   Boundary = Box(31.4540, 49.7470, 31.4630, 49.7530) },
                new { Id = 15, Name = "Промзона Канів",              ZoneType = "Restricted",   Description = "Промислова зона Канева — рух заборонено",        SpeedLimit = (double?)null,  Boundary = Box(31.4750, 49.7380, 31.4950, 49.7500) }
            );
        }
    }
}
