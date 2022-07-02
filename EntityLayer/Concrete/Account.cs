using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }
        public int SiteId { get; set; }
        public string SiteUserName { get; set; }
        public string SitePassword { get; set; }
        public virtual Site Site { get; set; }
        
    }
}
