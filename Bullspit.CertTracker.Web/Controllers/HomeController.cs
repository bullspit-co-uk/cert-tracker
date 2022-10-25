using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bullspit.CertTracker.Web.Models;
using Bullspit.CertTracker.Web.Models.Home;

namespace Bullspit.CertTracker.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        IndexPageVM model = new IndexPageVM();

        return View(model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorPageVM { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
