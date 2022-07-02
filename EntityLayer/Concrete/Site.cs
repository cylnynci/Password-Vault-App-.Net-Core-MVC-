using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Site
    {
        [Key]
        public int SiteId { get; set; }

        public string SiteName { get; set; }

        public string SiteAddress { get; set; }

        public string UserNameId { get; set; }

        public string PasswordId { get; set; }
    }
}
