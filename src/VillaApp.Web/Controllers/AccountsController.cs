using System;
using Microsoft.AspNetCore.Mvc;
using VillaApp.Web.Models;

namespace VillaApp.Web.Controllers
{
    public class AccountsController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if(!ModelState.IsValid) return View();
            throw new NotImplementedException();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterModel model)
        {
            if(!ModelState.IsValid) return View();
            throw new NotImplementedException();
        }
    }
}