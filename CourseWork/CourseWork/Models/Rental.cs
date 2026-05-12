using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseWork.Models
{
    public class Rental
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? TotalCost { get; set; }

        [Required]
        public int ClientId { get; set; }

        [ForeignKey(nameof(ClientId))]
        public Client Client { get; set; } = null!;

        [Required]
        public int VehicleId { get; set; }

        [ForeignKey(nameof(VehicleId))]
        public Vehicle Vehicle { get; set; } = null!;

        public int? StartRentalPointId { get; set; }

        [ForeignKey(nameof(StartRentalPointId))]
        public RentalPoint? StartRentalPoint { get; set; }
        public int? EndRentalPointId { get; set; }

        [ForeignKey(nameof(EndRentalPointId))]
        public RentalPoint? EndRentalPoint { get; set; }
    }
}
