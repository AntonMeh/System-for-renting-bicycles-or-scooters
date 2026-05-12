using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NetTopologySuite.Geometries;

namespace CourseWork.Models
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string SerialNumber { get; set; } = string.Empty;

        public int BatteryLevel { get; set; } = 100;

        public bool IsAvailable { get; set; } = true;

        [Column(TypeName = "geometry(Point,4326)")]
        public Point? CurrentLocation { get; set; }

        [Required]
        public int VehicleTypeId { get; set; }

        [ForeignKey(nameof(VehicleTypeId))]
        public VehicleType VehicleType { get; set; } = null!;

        public int? RentalPointId { get; set; }

        [ForeignKey(nameof(RentalPointId))]
        public RentalPoint? RentalPoint { get; set; }

        // Navigation: один транспорт — багато оренд
        public ICollection<Rental> Rentals { get; set; } = new List<Rental>();
    }
}
