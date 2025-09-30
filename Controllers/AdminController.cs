using Gruppe6Oppgave1.Web.Databases;
using Gruppe6Oppgave1.Web.Models;
using Microsoft.AspNetCore.Mvc;
using static Gruppe6Oppgave1.Web.Models.GetAllReportsModel;

namespace Gruppe6Oppgave1.Web.Controllers
{
    // AdminController endrer ikke på data, den viser bare rapport tabellen
    public class AdminController : Controller
    {
        private readonly DatabaseContext _context;
        public AdminController(DatabaseContext context)
        {
            _context = context;
        }
        // IActionResult lager liste som View returnerer
        public IActionResult Index()
        {
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
            return View(Model);
        }
    }
}
