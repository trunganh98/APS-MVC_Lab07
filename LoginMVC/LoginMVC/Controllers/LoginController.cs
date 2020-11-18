using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LoginMVC.Models;

namespace LoginMVC.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            AppUser user = new AppUser
            {
                UserName = "TrungAnh",
                PassWord = "123456"
            };

            return View(user);
        }

        [HttpPost]
        public IActionResult Index(AppUser user)
        {
            ViewBag.UserName = "Welcome to MVC!!!";
            return View(user);
        }
    }
}
