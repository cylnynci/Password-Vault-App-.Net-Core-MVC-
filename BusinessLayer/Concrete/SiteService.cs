using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SiteService : ISiteService
    {
        DataAccessProvider data = new DataAccessProvider(new Context());

        public Site Signup(Site oSite)
        {
            data.AddSite(oSite);
            return oSite;
        }

    }
}
