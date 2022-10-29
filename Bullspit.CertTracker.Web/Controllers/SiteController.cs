using System.Collections.Generic;
using Bullspit.CertTracker.Data;
using Bullspit.CertTracker.Web.Models.Shared;
using Bullspit.CertTracker.Web.Models.Site;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Bullspit.CertTracker.Web.Controllers
{
    public class SiteController : BaseController
    {
        public SiteController(ILogger<SiteController> logger)
         : base(logger)
        {
            SitesCollection = new Sites();
        }

        protected Sites SitesCollection { get; private set; }

        public IActionResult Index()
        {
            IndexVM result = new IndexVM();

            IList<Site> sites = SitesCollection.Get();

            foreach (Site site in sites)
            {
                result.Sites.Add(new SiteVM()
                {
                    Url = site.Url,
                    Name = site.Name
                });
            }

            return View(result);
        }
    }
}