using Gruppe6Oppgave1.Web.Databases;
using Gruppe6Oppgave1.Web.Models;
using Microsoft.AspNetCore.Mvc;
using static Gruppe6Oppgave1.Web.Models.GetAllReportsModel;

namespace Gruppe6Oppgave1.Web.Controllers
{
    // Klassen AdminController arver fra Controller klassen fra ASP NET
    public class AdminController : Controller
    {
        // Her er det kun tilgang til _context innenfor klassen DatabaseContext
        private readonly DatabaseContext _context;
        // Konstruktør
        public AdminController(DatabaseContext context)
        {
            _context = context;
        }
        // IActionResult forteller hva som skal vises i view
        public IActionResult Index()
        {
            // Variabel reports blir hentet fra Marker listen
            // Variabel Model tar inn listen fra GetAllReportsModel
            var reports = _context.Marker.ToList();
            var Model = new GetAllReportsModel();
            // Foreach løkke som legger til hver rad i Model
            // Raden består av Navn, etc
            foreach (var report in reports)
            {
                Model.Reports.Add(new MakeReportList
                {
                    Navn = report.Name,
                    Altitude = report.Altitude,
                    Longitude = report.Longitude,
                    Lattitude = report.Lattitude
                });
            }
            // Returnerer view Model
            return View(Model);
        }
    }
}
