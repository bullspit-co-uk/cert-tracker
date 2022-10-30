using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bullspit.CertTracker.Web.Models.Shared
{
    public class SiteVM : BasePageVM
    {
        public SiteVM() : base("Site")
        {
            Url = string.Empty;
            Name = string.Empty;
        }

        [DisplayName("URL")]
        [Required]
        public string Url { get; set; }

        [DisplayName("Name")]
        [Required]
        public string Name { get; set; }
    }
}