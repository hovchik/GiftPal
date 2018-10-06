using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using AutoMapper;
using GiftPalWeb.Helper;
using GiftPalWeb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Models;
using Newtonsoft.Json;

namespace GiftPalWeb.Controllers
{
    public class AccountController : Controller
    {
        //private readonly ISessionManager _sessionManager;
        //public AccountController(ISessionManager sessionManager)
        //{
        //    _sessionManager = sessionManager;
        //}
        public async Task<IActionResult> Index()
        {

            return View();
        }
        public async Task<IActionResult> Login(bool isLogin)
        {
            UsersModel model = new UsersModel() { IsLogin = isLogin };
            return PartialView("_Login", model);
        }
        [HttpPost]
        public async Task<IActionResult> Login(UsersModel model)
        {
            if (ModelState.IsValid)
            {
                Users user = new Users()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    Password = model.Password,
                    BirthDay = DateTime.Now.AddYears(-20),
                };
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:5261/");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var createdUserReq = await client.PostAsJsonAsync("api/CreateUser", user);
                    var result = await createdUserReq.Content.ReadAsAsync<int>();
                }
                //_sessionManager.User = model;
                return RedirectToAction("Index");
            }
            return View("_Login",model);
        }
    }
}