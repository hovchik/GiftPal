using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GiftPalWeb.Models;
using Microsoft.AspNetCore.Identity;
using Models;

namespace GiftPalWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //IdentityUser u = new IdentityUser();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //public IActionResult Login()
        //{
        //    return PartialView();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public async Task<IActionResult> SendGift()
        {
            return View();
        }
    }
}
