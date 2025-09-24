using Gruppe6Oppgave1.Models;
using Gruppe6Oppgave1.Web.Models;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using System.Diagnostics;

namespace Gruppe6Oppgave1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        private readonly string _connectionString;

        //public IActionResult Index()
        //{
        //    return View();
        //}

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

        public HomeController(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("DefaultConnection")!;
        }

        public async Task<IActionResult> Index()
        {
            string viewModel1 = ("Connected to MariaDB succsesfully");
            string viewModel2 = ("Failed to connect to MariaDB");
            try
            {
                await using var conn = new MySqlConnection(_connectionString);
                await conn.OpenAsync();
                return View("Index", viewModel1);
            }
            catch (Exception ex)
            {
                return View("Index", viewModel2);
            }
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
