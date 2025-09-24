using Microsoft.AspNetCore.Antiforgery;
using System.ComponentModel.DataAnnotations;

namespace Gruppe6Oppgave1.Models
{
    public class ObstacleData
    {
        [Required(ErrorMessage = "Field is required")]
        [MaxLength(100)]
        public string Objektnavn { get; set; }


        [Required(ErrorMessage = "Field is required")]
        [MaxLength(100)]
        public string Objekt_beskrivelse { get; set; }

        [Required(ErrorMessage = "Field is required")]
        [Range(0, 200)]
        public double Lattitude { get; set; }

        [Required(ErrorMessage = "Field is required")]
        [Range(0, 200)]
        public double Longitude { get; set; }

        [Required(ErrorMessage = "Field is required")]
        [Range(0, 100)]
        public int AMSL { get; set; }

    }
}
