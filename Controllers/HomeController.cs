using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Gruppe6Oppgave1.Web.Models;

namespace Gruppe6Oppgave1.Web.Controllers;

public class HomeSubmitModel
{
    public List<Report> AllReports { get; set; } = [];
    public double NewLatitude { get; set; }
    public double NewLongitude { get; set; }
}

public class ReportService
{
    private readonly List<Report> _reports = [];
    
    public void AddReport(Report report) => _reports.Add(report);
    
    public IEnumerable<Report> GetAllReports() => _reports;
}

public class Report
{
    public double Latitude { get; set; }
    public double Longitude { get; set; }

    public Report(double lat, double log)
    {
        Latitude = lat;
        Longitude = log;
    }
}

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ReportService _reportService;

    public HomeController(ILogger<HomeController> logger, ReportService reportService)
    {
        _logger = logger;
        _reportService = reportService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var view = new HomeSubmitModel
        {
            AllReports = _reportService.GetAllReports().ToList()
        };
        
        return View(view);
    }

    [HttpPost]
    public IActionResult Index(HomeSubmitModel body)
    {
        // if (ModelState.IsValid == false)
        if (!ModelState.IsValid)
            return View(body);

        var report = new Report(body.NewLatitude, body.NewLongitude);
        _reportService.AddReport(report);
        
        var view = new HomeSubmitModel
        {
            AllReports = _reportService.GetAllReports().ToList()
        };

        return View(view);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
