using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ISiteService : IGenericService<Site>
    {
        Site Signup(Site oSite);
        //List<Site> GetAllSites();
        //Site TDelete(int SiteId);
        //Site TUpdate(Site site);


    }
}
