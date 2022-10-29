using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bullspit.CertTracker.Data.Store
{
    internal class Site
    {
        public Site()
        {
            Url = string.Empty;
            Name = string.Empty;
        }

        public Site(string url)
            : this()
        {
            Url = url;
        }

        [Key]
        [Column("url")]
        public string Url { get; set; }

        [Column("name")]
        public string Name { get; set; }
    }
}