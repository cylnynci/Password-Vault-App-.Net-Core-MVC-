using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PasswordVaultApp.Models
{
    public class Site
    {
        public int SiteId { get; set; }

        [Required(ErrorMessage = "Please enter a Site name")]
        public string SiteName { get; set; }

        [Required(ErrorMessage = "Please enter a Site address")]
        public string SiteAddress { get; set; }

        public string UserNameId { get; set; }

        public string PasswordId { get; set; }
    }
}
