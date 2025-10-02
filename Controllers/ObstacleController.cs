using Gruppe6Oppgave1.Models;
using Gruppe6Oppgave1.Web.Databases;
using Gruppe6Oppgave1.Web.Databases.Tables;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Gruppe6Oppgave1.Controllers
{
    // Klassen ObstacleController arver fra Controller klassen fra ASP.net
    public class ObstacleController : Controller
    {
        
        [HttpGet] //Henter data fra server
        // IActionResult definerer en klasse som skal brukes senere av ActionResult metoden
        public IActionResult DataForm() //IActionresult returnerer viewet dataform
        {
            return View(); //Returnerer viewet dataform.cshtml
        }
        // Kobler sammen input til databasen
        private readonly DatabaseContext _context; // Definerer en privat variabel _context av typen DatabaseContext
        public ObstacleController(DatabaseContext context) // Konstruktør, tar inn DatabaseContext som parameter
        {
            _context = context; // Setter den private variabelen _context til å peke på context som blir sendt inn
        }

        [HttpPost] // Sender data til server
        public IActionResult DataForm(ObstacleData obstacledata) // IActionresult returnerer viewet dataform, og tar inn obstacledata som parameter
        {
            if (!ModelState.IsValid) //Sjekker om modellen er riktig
            {
                return View(obstacledata); //Hvis ikke, returneres viewet med obstacledata
            }


            var marker = new Marker() //Lager et nytt objekt av typen Marker
            {
                // Id blir automatisk generert av databasen
                Altitude = obstacledata.AMSL, // Høyde over havet
                Lattitude = obstacledata.Lattitude, // Breddegrad
                Longitude = obstacledata.Longitude, // Lengdegrad
                Description = obstacledata.Objekt_beskrivelse, // Beskrivelse av objektet
                Name = obstacledata.Objektnavn // Navn på objektet
            };
            _context.Marker.Add(marker); // Legger til det nye marker-objektet i Marker-tabellen i databasen
            _context.SaveChanges(); // Lagrer endringene i databasen

            return View("Overview", obstacledata); // Returnerer viewet overview.cshtml
        }

    }
}
