using Microsoft.AspNetCore.Mvc;

namespace Gruppe6Oppgave1.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
