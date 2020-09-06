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
        private readonly CategoryManager _categoryManager;
        private readonly AuthorManager   _authorManager;


        public HomeController(ILogger<HomeController> logger, IBlogDal blogsDal, ICategoryDal categoryDal, IAuthorDal authorDal)
        {
            _logger = logger;
            _blogManager = new BlogManager(blogsDal);
            _categoryManager = new CategoryManager(categoryDal);
            _authorManager = new AuthorManager(authorDal);
        }

        public IActionResult Index()
        {
            return View(new ListViewModel 
            {
                blogs = _blogManager.GetAll(),
                categories = _categoryManager.GetAll(),
                authors = _authorManager.GetAll()
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
