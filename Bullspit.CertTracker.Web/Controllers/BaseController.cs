using System.Diagnostics;
using Bullspit.CertTracker.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Bullspit.CertTracker.Web.Controllers
{
    public abstract class BaseController : Controller
    {
        public BaseController(ILogger logger)
        {
            Logger = logger;
        }

        protected ILogger Logger { get; private set; }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorPageVM { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}