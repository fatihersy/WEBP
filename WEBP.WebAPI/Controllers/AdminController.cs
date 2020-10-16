using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WEBP.BLL.Concrete;
using WEBP.DAL.Interfaces;
using WEBP.Entities.UI;
using WEBP.Entities.Database;
using WEBP.WebAPI.Models;

namespace WEBP.WebAPI.Controllers
{
    public class AdminController : Controller
    {
        private readonly BlogManager _blogManager;
        private readonly CategoryManager _categoryManager;
        private readonly AuthorManager _authorManager;

        public AdminController(IBlogDal blogsDal, ICategoryDal categoryDal, IAuthorDal authorDal)
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
                Categories = (await _categoryManager.GetAllAsync()).Select(k => k.name).ToList()
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
                    Categories = (await _categoryManager.GetAllAsync()).Select(k => k.name).ToList()
                });
            }

            var instance = new Blog
            {
                title = blog.title,
                authorId = 1,
                categoryid = (await _categoryManager.GetByNameAsync(blog.category)).id,
                uniqueid = Guid.NewGuid()
            };
            
            if ( await _blogManager.AddAsync(instance))
                return View();
            else
                return BadRequest();

        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            return View(new ListPanelViewModel
            {
                Blogs = await _blogManager.GetAllWithIdAsync(),
                Categories = await _categoryManager.GetAllWithIdAsync(),
                Authors = await _authorManager.GetAllWithIdAsync()
            });
        }

        public async Task<IActionResult> Update()
        {
            var blogs = await _blogManager.GetAllAsync();

            if( blogs.Any() )
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
