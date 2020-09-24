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
    public class OyunController : Controller
    {
        private readonly BlogManager _blogManager;
        private readonly NavitemManager _navitemManager;

        public OyunController(IBlogDal blogsDal, ICategoryDal categoryDal, INavitemDal navitemDal)
        {
            _blogManager = new BlogManager(blogsDal, categoryDal, null);
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
                return View(new OyunViewModel
                {
                    blogs = blogs
                });
            }

            return Index(1);
        }
    }
}
