using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseWork.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string Patronymic { get; set; } = string.Empty;

        [Required]
        [MaxLength(15)]
        public string Phone { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string Email { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Balance { get; set; } = 0;

        // Navigation: один клієнт — багато оренд
        public ICollection<Rental> Rentals { get; set; } = new List<Rental>();
    }
}
