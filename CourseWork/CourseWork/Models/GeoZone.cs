using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NetTopologySuite.Geometries;

namespace CourseWork.Models
{
    /// <summary>
    /// Географічна зона обслуговування / обмеження.
    /// Полігон визначає межі зони (наприклад, зона паркування, заборонена зона).
    /// </summary>
    public class GeoZone
    {
        [Key]
        public int Id { get; set; }

        /// <summary>Назва зони.</summary>
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        /// <summary>Опис зони.</summary>
        [MaxLength(500)]
        public string? Description { get; set; }

        /// <summary>Тип зони: Allowed, Restricted, SpeedLimited, Parking.</summary>
        [Required]
        [MaxLength(30)]
        public string ZoneType { get; set; } = "Allowed";

        /// <summary>Обмеження швидкості в зоні (км/год). Null — без обмеження.</summary>
        public double? SpeedLimit { get; set; }

        /// <summary>Полігон, що визначає межі зони (PostGIS Polygon, SRID 4326).</summary>
        [Required]
        [Column(TypeName = "geometry(Polygon,4326)")]
        public Polygon Boundary { get; set; } = null!;
    }
}
