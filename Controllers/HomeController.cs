using Gruppe6Oppgave1.Models;
using Gruppe6Oppgave1.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Gruppe6Oppgave1.Controllers
{
    // Controller som håndterer hjem-siden, HomeController arver fra Controller-klassen
    public class HomeController : Controller
    {
        [HttpGet] //Denne henter data fra server
        //IActionresult gjør at det kan returnere forskjellige typer resultater
        public IActionResult Index() // IActionresult returnerer viewet Index fra view/home/index
        {
            return View(); // Returnerer viewet Index.cshtml, siden det er i samme blokk
        }

        // IActionresult returnerer viewet privacy
        public IActionResult Privacy() // Returnerer viewet Privacy
        {
            return View(); // Returnerer viewet Privacy.cshtml
        }

        [HttpPost] //Denne sender data til server

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)] // Angir at denne actionen ikke skal caches
        public IActionResult Error() // Returnerer viewet Error med en ErrorViewModel fra Models-mappen
        {
            // Returnerer viewet Error.cshtml med en ny instans av ErrorViewModel som inneholder RequestId
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
