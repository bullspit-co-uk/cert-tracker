namespace Bullspit.CertTracker.Data
{
    public class Site
    {
        public Site()
        {
            Url = string.Empty;
            Name = string.Empty;
        }

        public string Url { get; set; }
        public string Name { get; set; }
    }
}