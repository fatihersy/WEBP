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

        public OyunController(IBlogDal blogsDal, ICategoryDal categoryDal, IAuthorDal authorDal, INavitemDal navitemDal)
        {
            _blogManager = new BlogManager(blogsDal, categoryDal, authorDal);
            _navitemManager = new NavitemManager(navitemDal);
        }

        public IActionResult Index(int page)
        {
            ViewBag.navitems = _navitemManager.GetAll();

            return View(new OyunViewModel
            {
                blogs = _blogManager.GetAll(page*10, 10)
            });

        }
    }
}
