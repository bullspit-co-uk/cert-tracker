using System.Collections.Generic;
using Bullspit.CertTracker.Web.Models.Shared;

namespace Bullspit.CertTracker.Web.Models.Site
{
    public class IndexVM : BasePageVM
    {
        public IndexVM() : base("Sites")
        {
            SiteHeader = new SiteVM();
            Sites = new List<SiteVM>();
        }

        public SiteVM SiteHeader { get; set; }

        public List<SiteVM> Sites { get; set; }
    }
}