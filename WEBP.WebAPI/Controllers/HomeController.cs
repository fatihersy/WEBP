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

        public HomeController(ILogger<HomeController> logger, IBlogDal blogsDal, ICategoryDal categoryDal, IAuthorDal authorDal, INavitemDal navitemDal)
        {
            _logger = logger;
            _blogManager = new BlogManager(blogsDal, categoryDal, authorDal);
            _navitemManager = new NavitemManager(navitemDal);
        }

        public IActionResult Index()
        {
            ViewBag.navitems = _navitemManager.GetAll();

            return View( new HomeViewModel
            {
                blogs = _blogManager.GetAll()
            });
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
