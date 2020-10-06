using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using WEBP.BLL.Concrete;
using WEBP.DAL.Interfaces;
using WEBP.WebAPI.Models;

namespace WEBP.WebAPI.Controllers
{
    public class BlogController : Controller
    {
        private readonly BlogManager _blogManager;
        private readonly NavitemManager _navitemManager;

        public BlogController(IBlogDal blogsDal, ICategoryDal categoryDal, IAuthorDal authorDal, INavitemDal navitemDal)
        {
            _blogManager = new BlogManager(blogsDal, categoryDal, authorDal);
            _navitemManager = new NavitemManager(navitemDal);
        }

        [HttpGet]
        public async Task<IActionResult> Index(Guid id)
        {
            ViewBag.navitems = _navitemManager.GetAllAsync();

            return View(new BlogViewModel
            {
                blog = await _blogManager.GetByIdAsync(id)
            });
        }
    }
}
