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

        public IActionResult Details(string id, bool partial = false)
        {
            SiteVM? result = null;

            Site? site = SitesCollection.Get(id);

            if (site != null)
            {
                result = new SiteVM()
                {
                    Url = site.Url,
                    Name = site.Name
                };

                if (!partial)
                {
                    return View(result);
                }
                else
                {
                    return PartialView(result);
                }
            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult Add()
        {
            SiteAddVM result = new SiteAddVM();

            return View(result);
        }

        [HttpPost]
        public IActionResult Add(SiteAddVM site)
        {
            bool isSuccess = false;

            if (ModelState.IsValid)
            {
                isSuccess = SitesCollection.Create(new Site()
                {
                    Url = site.Url,
                    Name = site.Name
                });
            }

            if (isSuccess)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(site);
            }
        }

        public IActionResult Delete(string id, bool partial = false)
        {
            SiteVM? result = null;

            Site? site = SitesCollection.Get(id);

            if (site != null)
            {
                result = new SiteVM()
                {
                    Url = site.Url,
                    Name = site.Name
                };

                if (!partial)
                {
                    return View(result);
                }
                else
                {
                    return PartialView(result);
                }
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult Delete(string id)
        {
            Site? site = SitesCollection.Get(id);

            if (site != null)
            {
                SitesCollection.Delete(site);

                return RedirectToAction("Index");
            }
            else
            {
                return NotFound();
            }
        }
    }
}