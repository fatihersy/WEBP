using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using WEBP.BLL.Concrete;
using WEBP.DAL.Interfaces;
using WEBP.WebAPI.Models;

namespace WEBP.WebAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly BlogManager _blogManager;
        private readonly NavitemManager _navitemManager;

        public HomeController(ILogger<HomeController> logger, IBlogDal blogsDal, ICategoryDal categoryDal, INavitemDal navitemDal)
        {
            _logger = logger;
            _blogManager = new BlogManager(blogsDal, categoryDal, null);
            _navitemManager = new NavitemManager(navitemDal);
        }

        [HttpGet]
        public async Task<IActionResult> Index(int page)
        {
            ViewBag.navitems = await _navitemManager.GetAllAsync();

            var blogs = await _blogManager.GetAllAsync(page, 12);

            ViewBag.page = page;
            ViewBag.ipages =
                Math.Ceiling(
                    (float) ( await _blogManager.GetRowCountAsync() )  / (float)12
                );

            if (blogs.Count != 0)
            {
                return View(new HomeViewModel
                {
                    blogs = blogs
                });
            }

            return NotFound();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
