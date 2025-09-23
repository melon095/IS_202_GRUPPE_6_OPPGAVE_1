using Gruppe6Oppgave1.Web.Databases;
using Gruppe6Oppgave1.Web.Models;
using Microsoft.AspNetCore.Mvc;
using static Gruppe6Oppgave1.Web.Models.GetAllReportsModel;

namespace Gruppe6Oppgave1.Web.Controllers
{
    public class AdminController : Controller
    {
        private readonly DatabaseContext _context;
        public AdminController(DatabaseContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var reports = _context.Marker.ToList();
            var Model = new GetAllReportsModel();
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
