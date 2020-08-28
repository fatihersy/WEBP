using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WEBP.BLL.Concrete;
using WEBP.DAL.Interfaces.EntityFramework;
using WEBP.Entities;
using WEBP.WebAPI.Models;

namespace WEBP.WebAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly BlogsManager _blogsManager;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IBlogsDal blogsDal)
        {
            _logger = logger;
            _blogsManager = new BlogsManager(blogsDal);
        }

        public IActionResult Index()
        {
            return View(new ListViewModel 
            {
                blogs = _blogsManager.GetAll()
            });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
