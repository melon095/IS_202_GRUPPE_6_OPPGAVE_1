using Microsoft.AspNetCore.Antiforgery;
using System.ComponentModel.DataAnnotations;

namespace Gruppe6Oppgave1.Models
{
    public class ObstacleData // Klasse som representerer data for et hinder/objekt
    {
        [Required(ErrorMessage = "Objektnavn påkrevd")] // Feltet er påkrevd, og en feilmelding vises hvis det ikke er fylt ut
        [MaxLength(100)] // Maksimal lengde på 100 tegn
        public string Objektnavn { get; set; } // Navn på objektet


        [Required(ErrorMessage = "Objektbeskrivelse påkrevd")] // Feltet er påkrevd, og en feilmelding vises hvis det ikke er fylt ut
        [MaxLength(100)] // Maksimal lengde på 100 tegn
        public string Objekt_beskrivelse { get; set; } // Beskrivelse av objektet

        [Required(ErrorMessage = "Lattitude over havet påkrevd ")] // Feltet er påkrevd, og en feilmelding vises hvis det ikke er fylt ut
        [Range(0, 200)] // Det må skrives noe mellom 0 og 200
        public double Lattitude { get; set; } // Breddegrad

        [Required(ErrorMessage = "Longitude er påkrevd")] //Feltet er påkrevd, og en feilmelding vises hvis det ikke er fylt ut
        [Range(0, 200)] // Det må skrives noe mellom 0 og 200
        public double Longitude { get; set; } // Lengdegrad

        [Required(ErrorMessage = "Høyde over havet påkrevd")] //Feltet er påkrevd, og en feilmelding vises hvis det ikke er fylt ut
        [Range(0, 100)] // Det må skrives noe mellom 0 og 100
        public int AMSL { get; set; } // Høyde over havet (Above Mean Sea Level)

    }
}
