using Microsoft.AspNetCore.Mvc;

namespace Gruppe6Oppgave1.Controllers
{
    // Klassen MapController arver fra Controller klassen fra ASP.net
    public class MapController : Controller
    {
        // IActionResult definerer en klasse som skal brukes senere av ActionResult metoden
        public IActionResult Index()
        {
            //Metoden retunerer index.cshtml fra Views/Map
            return View();
        }
    }
}
