using Gruppe6Oppgave1.Models;
using Gruppe6Oppgave1.Web.Databases;
using Gruppe6Oppgave1.Web.Databases.Tables;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Gruppe6Oppgave1.Controllers
{
    public class ObstacleController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        [HttpGet]
        public ActionResult DataForm()
        {
            return View();
        }
        // Kobler sammen input til databasen
        private readonly DatabaseContext _context;
        public ObstacleController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpPost]
        public ActionResult DataForm(ObstacleData obstacledata)
        {
            if (!ModelState.IsValid)
            {
                return View(obstacledata);
            }

            var marker = new Marker()
            {
                Altitude = obstacledata.AMSL,
                Lattitude = obstacledata.Lattitude,
                Longitude = obstacledata.Longitude,
                Description = obstacledata.Objekt_beskrivelse,
                Name = obstacledata.Objektnavn
            };
            _context.Marker.Add(marker);
            _context.SaveChanges();
            
            return View("Overview", obstacledata);
        }

    }
}
