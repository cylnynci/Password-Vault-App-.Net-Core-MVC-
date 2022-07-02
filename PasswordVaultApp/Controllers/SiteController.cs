using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PasswordVaultApp.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PasswordVaultApp.Controllers
{
    [UserFilter]
    public class SiteController : Controller
    {
        private Context db = new Context();

        ISiteService _siteService = new SiteService();

        [HttpGet]
        public ActionResult AddSite()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSite(Site oSite)
        {
            _siteService.Signup(oSite);
            var model = db.Sites.ToList();
            return RedirectToAction("SiteList", model);
        }

        [HttpGet]
        public ViewResult SiteList()
        {
            var model = db.Sites.ToList();
            return View(model);
        }

        public ActionResult DeleteSite(int SiteId)
        {
            var site = db.Sites.Find(SiteId);
            db.Sites.Remove(site);
            db.SaveChanges();
            return RedirectToAction("SiteList");

        }

        [HttpGet]
        public ActionResult GetSite(int SiteId)
        {
            var site = db.Sites.Find(SiteId);
            return View("GetSite", site);
        }

        public ActionResult UpdateSite(Site oSite)
        {
            var site = db.Sites.Find(oSite.SiteId);
            site.SiteId = oSite.SiteId;
            site.SiteName = oSite.SiteName;
            site.SiteAddress = oSite.SiteAddress;
            db.SaveChanges();
            return RedirectToAction("SiteList");

        }

        [HttpPost]
        public JsonResult AutoComplete(string prefix)
        {
            var users = (from user in this.db.Users
                         where user.UserName.StartsWith(prefix)
                         select new
                         {
                             label = user.UserName,
                             val = user.UserId
                         }).ToList();

            return Json(users);
        }
      
        public IActionResult GetInputInformation(string str)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddAdditionalCapability("useAutomationExtension", false);
            options.AddExcludedArgument("enable-automation");
            WebDriver driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl(str);

            string PasswordId="";
            string UserNameId="";

            IList<IWebElement> inputs = driver.FindElements(By.TagName("input"));
            foreach (IWebElement i in inputs)
            {
                string tur = i.GetDomAttribute("type");
                string hidden = i.GetDomAttribute("hidden");
                string sinif = i.GetDomAttribute("class");
                string name = i.GetDomAttribute("name");
                
                if (tur == "password")
                {
                    PasswordId = i.GetDomAttribute("id");
                    
                }
                else if ((tur == "text" || tur == "email") && hidden != "true" && sinif != "search-box" && sinif != "pw-search-input" && sinif != "form-control product-search__input js-product-search-input js-illegal-characters" && sinif != "form-control js-placeholder js-password-recovery-input" && sinif != "react-autosuggest__input" && sinif != "location ui-autocomplete-input" && name != "query" && name != "query_text")
                {
                    UserNameId = i.GetDomAttribute("id");

                }
            }
            var model = new List<string>();
            model.Add(PasswordId);
            model.Add(UserNameId);          

            return Json(model);
        }
       
    }
}
