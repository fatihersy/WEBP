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
    public class BlogController : Controller
    {
        private readonly BlogManager _blogManager;
        private readonly NavitemManager _navitemManager;

        public BlogController(IBlogDal blogsDal, ICategoryDal categoryDal, IAuthorDal authorDal, INavitemDal navitemDal)
        {
            _blogManager = new BlogManager(blogsDal, categoryDal, authorDal);
            _navitemManager = new NavitemManager(navitemDal);
        }

        public IActionResult Index(string id)
        {
            ViewBag.navitems = _navitemManager.GetAll();

            return View(new BlogViewModel
            {
                blog = _blogManager.GetById(id)
            });
        }
    }
}
