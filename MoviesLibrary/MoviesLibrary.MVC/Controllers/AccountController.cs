using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MoviesLibrary.Models;

namespace MoviesLibrary.MVC.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost] 
        public ActionResult Register(UserAccount account)
        {
            //if(ModelState.IsValid)

            return View();
        }
    }
}