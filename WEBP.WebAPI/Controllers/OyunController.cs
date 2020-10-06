﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
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

        [HttpGet]
        public async Task<IActionResult> Index(int page)
        {
            ViewBag.navitems = await _navitemManager.GetAllAsync();

            var blogs = await _blogManager.GetAllAsync(page, 12);

            ViewBag.page = page;
            ViewBag.ipages =
                Math.Ceiling(
                    (float) ( await _blogManager.GetRowCountAsync() ) / (float)12
                );

            if (blogs.Count != 0)
            {
                return View(new OyunViewModel
                {
                    blogs = blogs
                });
            }

            return await Index(1);
        }
    }
}
