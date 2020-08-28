using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WEBP.BLL.Concrete;
using WEBP.DAL.Interfaces.EntityFramework;
using WEBP.WebAPI.Models;

namespace WEBP.WebAPI.Controllers
{
    public class ListController : Controller
    {
        private readonly BlogsManager _blogsManager;

        public ListController(IBlogsDal blogsDal)
        {
            _blogsManager = new BlogsManager(blogsDal);
        }

        public IActionResult Index()
        {
            ListViewModel listViewModel = new ListViewModel {
                blogs = _blogsManager.GetAll()
            };

            return View(listViewModel);
        }
    }
}
