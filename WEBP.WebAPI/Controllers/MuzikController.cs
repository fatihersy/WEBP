using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WEBP.BLL.Concrete;
using WEBP.DAL.Interfaces;
using WEBP.WebAPI.Models;

namespace WEBP.WebAPI.Controllers
{
    public class MuzikController : Controller
    {
        private readonly BlogManager _blogManager;
        private readonly NavitemManager _navitemManager;

        public MuzikController(IBlogDal blogsDal, ICategoryDal categoryDal, IAuthorDal authorDal, INavitemDal navitemDal)
        {
            _blogManager = new BlogManager(blogsDal, categoryDal, authorDal);
            _navitemManager = new NavitemManager(navitemDal);
        }

        public IActionResult Index(int page)
        {
            ViewBag.navitems = _navitemManager.GetAll();

            var blogs = _blogManager.GetAll(page, 12);

            ViewBag.page = page;
            ViewBag.ipages =
                Math.Ceiling(
                    (float)_blogManager.GetRowCount() / (float)12
                );

            if (blogs.Count != 0)
            {
                return View(new MuzikViewModel
                {
                    blogs = blogs
                });
            }

            return Index(1);
        }
    }
}
