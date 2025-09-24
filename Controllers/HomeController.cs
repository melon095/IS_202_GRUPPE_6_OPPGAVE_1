using Gruppe6Oppgave1.Models;
using Gruppe6Oppgave1.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Gruppe6Oppgave1.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult DataForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DataForm(ObstacleData obstacledata)
        {
            return View("Overview", obstacledata);
        }

        public async Task<IActionResult> Index()
        {
            return View("Index");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
