using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WEBP.BLL.Concrete;
using WEBP.DAL.Interfaces;
using WEBP.Entities.UI;
using WEBP.Entities.Database;
using WEBP.WebAPI.Models;
using System.Reflection;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WEBP.WebAPI.Controllers
{
    public class AdminController : Controller
    {
        private readonly BlogManager _blogManager;
        private readonly CategoryManager _categoryManager;
        private readonly AuthorManager _authorManager;

        public AdminController(IBlogDal blogsDal, ICategoryDal categoryDal, IAuthorDal authorDal, INavitemDal navitemDal)
        {
            _blogManager = new BlogManager(blogsDal, null, null);
            _categoryManager = new CategoryManager(categoryDal);
            _authorManager = new AuthorManager(authorDal);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View(new CreatePanelViewModel 
            {
                categories = (await _categoryManager.GetAllAsync()).Select(k => k.name).ToList()
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( UiBlog blog )
        {
            if (!ModelState.IsValid)
            {
                return View(new CreatePanelViewModel
                {
                    categories = (await _categoryManager.GetAllAsync()).Select(k => k.name).ToList()
                });
            }

            if ( await _blogManager.AddAsync(new Blog
            {
                title = blog.title,
                authorId = 1,
                categoryid = ( await _categoryManager.GetByNameAsync(blog.category) ).id,
                uniqueid = Guid.NewGuid()
            }))
                return View();
            else
                return BadRequest();

        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            return View(new ListPanelViewModel
            {
                blogs = await _blogManager.GetAllWithIdAsync(),
                categories = await _categoryManager.GetAllWithIdAsync(),
                authors = await _authorManager.GetAllWithIdAsync()
            });
        }

        public async Task<IActionResult> Update()
        {
            var blogs = await _blogManager.GetAllAsync();

            if( blogs.Count() > 0 )
            {
                return View();
            }
            else
            {
                return BadRequest();
            }
            
        }

        public IActionResult Delete()
        {


            return View();
        }
    }
}
