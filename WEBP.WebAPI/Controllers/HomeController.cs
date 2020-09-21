using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WEBP.BLL.Concrete;
using WEBP.DAL.Interfaces;
using WEBP.WebAPI.Models;

namespace WEBP.WebAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly BlogManager     _blogManager;
        private readonly NavitemManager _navitemManager;

        public HomeController(ILogger<HomeController> logger, IBlogDal blogsDal, INavitemDal navitemDal)
        {
            _logger = logger;
            _blogManager = new BlogManager(blogsDal, null, null);
            _navitemManager = new NavitemManager(navitemDal);
        }

        public IActionResult Index(int page)
        {
            ViewBag.navitems = _navitemManager.GetAll();

            var blogs = _blogManager.GetAll(page, 12);

            ViewBag.page = page;
            ViewBag.ipages = 
                Math.Ceiling( 
                    (float) _blogManager.GetRowCount() / (float) 12 
                );
            
            if( blogs.Count != 0 )
            {
                return View( new HomeViewModel
                {
                    blogs = blogs
                });
            }

            return Index(1);
        }

        public IActionResult Privacy()
        {
            return View("Privacy");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
