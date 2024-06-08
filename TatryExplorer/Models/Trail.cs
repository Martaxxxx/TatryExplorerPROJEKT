using System.ComponentModel.DataAnnotations;

namespace TatryExplorer.Models
{
    public class Trail
    {
        public int Id { get; set; }

        [Required]
        public string? Nazwa { get; set; }

        [Required]
        public double Długość { get; set; }

        [Required]
        public string? PoziomTrudności { get; set; }

        [Required]
        public string? OpisSzlaku { get; set; }

        public string? UserId { get; set; } // Dodane pole
    }
}
