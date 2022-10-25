namespace Bullspit.CertTracker.Web.Models
{
    public abstract class BasePageVM
    {
        public BasePageVM()
        {
            PageTitle = "Page";
        }

        public BasePageVM(string pageTitle) : this()
        {
            PageTitle = pageTitle;
        }

        public string PageTitle { get; private set; }
    }
}