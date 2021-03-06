﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using WEBP.BLL.Concrete;
using WEBP.DAL.Interfaces;
using WEBP.Entities.UI;
using WEBP.WebAPI.Models;

namespace WEBP.WebAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductManager _productManager;
        private readonly LoginManager _logInManager;

        public HomeController(IProductDal productDal, ILoginDal loginDal, IUserDal userDal, IMembershipsDal membershipsDal)
        {
            _productManager = new ProductManager(productDal, userDal);
            _logInManager = new LoginManager(loginDal, userDal, membershipsDal);
        }

        [HttpGet]
        public async Task<IActionResult> Index(int page)
        {
            //if (page < 1) await Index(1);
            
            var products = await _productManager.GetAllWithSizeAsync(page, 12);

            if (!products.Any()) return BadRequest();
            
            ViewBag.page = page;
            ViewBag.ipages =
                Math.Ceiling(
                    await _productManager.GetRowCountAsync()  / (float)12
                );
            
            return View(new HomeViewModel
            {
                Products = products
            });
            

        }

        [HttpGet]
        public IActionResult LogIn()
        {
            return View(new LogInViewModel());
        }
        
        [HttpPost]
        public async Task<IActionResult> LogIn(UiLogin login)
        {
            if (!ModelState.IsValid) { return View(new LogInViewModel()); }
            
                var user = await _logInManager.LogIn(login);
            
            if ( user == "") { return View(new LogInViewModel()); }
            
            
            return View("LoggedIndex", new LoggedViewModel
            {
                Products = await _productManager.GetAllWithSizeAsync(1, 12),
                UserName = user
            });
        }
        
        [HttpGet]
        public IActionResult SingUp()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SingUp(UiUser user, UiLogin login, UiMemberships membership)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            
            var result = await _logInManager.SingUp( login, user, membership);
            
            if (result) return LogIn();
            
            
            return BadRequest();
        }
    }
}
