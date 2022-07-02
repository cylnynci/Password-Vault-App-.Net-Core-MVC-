using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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
    public class AccountController : Controller
    {
        private Context db = new Context();

        IAccountService _accountService = new AccountService();
        //IWebDriver driver = new ChromeDriver(options);

        [HttpGet]
        public ActionResult AddAccount()
        {
            List<SelectListItem> degerler = (from i in db.Sites.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.SiteName,
                                                 Value = i.SiteId.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            return View();
        }

        [HttpPost]
        public ActionResult AddAccount(Account oAccount)
        {

            _accountService.Signup(oAccount);
            var model = db.Accounts.ToList();
            return RedirectToAction("AccountList", model);

        }

        [HttpGet]
        public ViewResult AccountList()
        {
            var model = db.Accounts.Include(x => x.Site).ToList();

            List<Account>.Enumerator enumaratorAccount = model.GetEnumerator();
            while (enumaratorAccount.MoveNext())
            {
                enumaratorAccount.Current.SitePassword = EncryptDecrypt.DecryptString("1234567890123456", enumaratorAccount.Current.SitePassword);
            }
            return View(model);
        }

        public ActionResult DeleteAccount(int AccountId)
        {
            var account = db.Accounts.Find(AccountId);
            db.Accounts.Remove(account);
            db.SaveChanges();
            return RedirectToAction("AccountList");

        }

        [HttpGet]
        public ActionResult GetAccount(int AccountId)
        {
            List<SelectListItem> degerler = (from i in db.Sites.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.SiteName,
                                                 Value = i.SiteId.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;

            var account = db.Accounts.Find(AccountId);
            account.SitePassword = EncryptDecrypt.DecryptString("1234567890123456", account.SitePassword);
            return View("GetAccount", account);
        }

        public ActionResult UpdateAccount(Account oAccount)
        {
            var account = db.Accounts.Find(oAccount.AccountId);
            account.AccountId = oAccount.AccountId;
            account.SiteId = oAccount.SiteId;
            account.SiteUserName = oAccount.SiteUserName;
            account.SitePassword = EncryptDecrypt.EncryptString("1234567890123456", oAccount.SitePassword);
            db.SaveChanges();
            return RedirectToAction("AccountList");

        }


        [HttpGet]
        public ActionResult GetSessionInformation(int AccountId)
        {
            var account = db.Accounts.Find(AccountId);
            Site site = db.Sites.Find(account.SiteId);
            ChromeOptions options = new ChromeOptions();
            options.AddAdditionalCapability("useAutomationExtension", false);
            options.AddExcludedArgument("enable-automation");
            WebDriver driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl(site.SiteAddress);

            driver.FindElement(By.Id(site.UserNameId)).SendKeys(account.SiteUserName);
            account.SitePassword = EncryptDecrypt.DecryptString("1234567890123456", account.SitePassword);
            driver.FindElement(By.Id(site.PasswordId)).SendKeys(account.SitePassword);
    
            return Redirect("AccountList");
        }
    }
}