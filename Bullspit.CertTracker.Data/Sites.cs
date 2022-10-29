using System.Collections.Generic;
using System.Linq;
using Bullspit.CertTracker.Data.Store;

namespace Bullspit.CertTracker.Data
{
    public class Sites : BaseDAO
    {
        public Sites()
        { }

        public IList<Site> Get(int take = PAGE_SIZE, int skip = 0)
        {
            List<Site> result = new List<Site>();

            using (CertContext db = new CertContext())
            {
                result = (from s in db.Sites
                          select new Site()
                          {
                              Url = s.Url,
                              Name = s.Name
                          }).ToList();
            }

            return result;
        }

        public Site? Get(string url)
        {
            Site? result = null;

            using (CertContext db = new CertContext())
            {
                result = (from s in db.Sites
                          where s.Url == url
                          select new Site()
                          {
                              Url = s.Url,
                              Name = s.Name
                          }).SingleOrDefault();
            }

            return result;
        }

        public bool Create(Site site)
        {
            bool result = false;

            using (CertContext db = new CertContext())
            {
                Store.Site newSite = new Store.Site()
                {
                    Url = site.Url,
                    Name = site.Name
                };

                db.Sites.Add(newSite);
                result = db.SaveChanges() > 0;
            }

            return result;
        }

        public bool Delete(Site site)
        {
            bool result = false;

            using (CertContext db = new CertContext())
            {
                Store.Site target = db.Sites.Single(s => s.Url == site.Url);

                db.Sites.Remove(target);
                result = db.SaveChanges() > 0;
            }

            return result;
        }
    }
}