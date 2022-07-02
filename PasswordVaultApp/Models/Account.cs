using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PasswordVaultApp.Models
{
    public class Account
    {
        public int AccountId { get; set; }
        public int SiteId { get; set; }
        [Required(ErrorMessage = "Please enter a site username")]
        public string SiteUserName { get; set; }
        [Required(ErrorMessage = "Please enter a password")]
        public string SitePassword { get; set; }
        public virtual Site Site { get; set; }
    }
}
