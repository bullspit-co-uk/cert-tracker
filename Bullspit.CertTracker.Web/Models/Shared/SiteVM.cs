using System.ComponentModel;

namespace Bullspit.CertTracker.Web.Models.Shared
{
    public class SiteVM
    {
        public SiteVM()
        {
            Url = string.Empty;
            Name = string.Empty;
        }

        [DisplayName("URL")]
        public string Url { get; set; }

        [DisplayName("Name")]
        public string Name { get; set; }
    }
}