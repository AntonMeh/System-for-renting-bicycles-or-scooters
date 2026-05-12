using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NetTopologySuite.Geometries;

namespace CourseWork.Models
{
    public class RentalPoint
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(200)]
        public string Address { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "geometry(Point,4326)")]
        public Point Location { get; set; } = null!;

        // Navigation: транспорт на цій точці
        public ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();

        // Navigation: оренди, що починалися на цій точці
        public ICollection<Rental> RentalsStartedHere { get; set; } = new List<Rental>();

        // Navigation: оренди, що закінчилися на цій точці
        public ICollection<Rental> RentalsEndedHere { get; set; } = new List<Rental>();
    }
}
