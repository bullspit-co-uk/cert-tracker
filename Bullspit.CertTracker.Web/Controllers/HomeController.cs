using Bullspit.CertTracker.Web.Models.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Bullspit.CertTracker.Web.Controllers;

public class HomeController : BaseController
{
    public HomeController(ILogger<HomeController> logger)
     : base(logger)
    { }

    public IActionResult Index()
    {
        IndexPageVM model = new IndexPageVM();

        return View(model);
    }
}
