using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseWork.Models
{
    public class VehicleType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal UnlockFee { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PerMinuteRate { get; set; }

        // Navigation: один тип — багато транспортних засобів
        public ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
    }
}
