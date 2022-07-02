
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using PasswordVaultApp.Filter;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;


namespace PasswordVaultApp.Controllers
{
    [UserFilter]
    public class HomeController : Controller
    {
        private Context db = new Context();
        IUserService _userService = null;
        public HomeController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Index(User user)
        {
            user.Password = MD5Encrypt.Encrypt(user.Password);

            Context c = new Context();
        
            var datavalue = c.Users.FirstOrDefault(x => x.UserName == user.UserName && x.Password == user.Password);
            if(datavalue!=null)
            {
                HttpContext.Session.SetInt32("id",user.UserId);
                HttpContext.Session.SetString("username", user.UserName);

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,user.UserName)
                };
                var userIdentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("AccountList","Account");
            }
            else
            {
                return View();
            }
        }

        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return Redirect("Index");
        }

        //public IActionResult SignUp()
        //{
        //    if (HttpContext.Session.GetInt32("id").HasValue)
        //    {
        //        return Redirect("Account/AddAccount");
        //    }
        //    return View();
        //}

        //public async ViewResult Index(Login login)
        //{

        //    if (LoginUser(login.Username, login.Password))
        //    {
        //        var claims = new List<Claim>
        //    {
        //        new Claim(ClaimTypes.Name, login.Username)
        //    };

        //        var userIdentity = new ClaimsIdentity(claims, "login");

        //        ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
        //        await HttpContext.SignInAsync(principal);

        //        //Just redirect to our index after logging in. 
        //        return View("AddAccount");
        //    }
        //    return View("AddAccount");
        //}

        //public async Task<IActionResult> LogOut()
        //{
        //    await HttpContext.SignOutAsync();

        //    return RedirectToAction("Index");
        //}


        [HttpGet]
        public ViewResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public ViewResult AddUser(User oUser)
        {
            if (ModelState.IsValid)
            {
                //Model binding (User alanları ile formdaki kullanıcı verileri arasındadki eşleştirmenin yapıldığı yapı)
                //user bilgisi veritabanına kaydedilir.
                _userService.Signup(oUser);
                return View("Index");
            }
            return View();
        }
    }
}
