using Gruppe6Oppgave1.Web.Databases;
using Gruppe6Oppgave1.Web.Models;
using Microsoft.AspNetCore.Mvc;
using static Gruppe6Oppgave1.Web.Models.GetAllReportsModel;

namespace Gruppe6Oppgave1.Web.Controllers
{
    // Klassen AdminController arver fra Controller klassen fra ASP.net'
    // Gir tilgang til actions som returnerer views
    public class AdminController : Controller
    {
        // Kobler sammen input til databasen
        private readonly DatabaseContext _context;
        // Konstruktør, tar inn DatabaseContext som parameter
        public AdminController(DatabaseContext context)
        {
            // Setter den private variabelen _context til å peke på context som blir sendt inn
            _context = context;
        }

        // Dette er standard action for en controller, her returneres viewet Index
        public IActionResult Index()
        {
            var reports = _context.Marker.ToList(); // _Context er databasekonteksten, Marker er tabellen, ToList() henter alle radene som en liste
            var Model = new GetAllReportsModel(); // Lager en ny instans av GetAllReportsModel som skal sendes til viewet
            foreach (var report in reports) // En løkke som går gjennom alle rapportene hentet fra databasen
            {
                Model.Reports.Add(new MakeReportList // Model.Reports er en liste, her legges nye objekter av typen MakeReportList til i listen
                {
                    Navn = report.Name,
                    Altitude = report.Altitude,
                    Longitude = report.Longitude,
                    Lattitude = report.Lattitude
                });
            }
            return View(Model); // Returnerer viewet Index og sender med modellen som inneholder listen av rapporter
        }
    }
}
