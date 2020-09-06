using Microsoft.AspNetCore.Mvc;
using WEBP.BLL.Concrete;
using WEBP.DAL.Interfaces;
using WEBP.WebAPI.Models;

namespace WEBP.WebAPI.Controllers
{
    public class ListController : Controller
    {
        private readonly BlogManager _blogsManager;

        public ListController(IBlogDal blogsDal)
        {
            _blogsManager = new BlogManager(blogsDal);
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
