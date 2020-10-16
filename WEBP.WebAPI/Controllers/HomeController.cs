using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using WEBP.BLL.Concrete;
using WEBP.DAL.Interfaces;
using WEBP.Entities.UI;
using WEBP.WebAPI.Models;

namespace WEBP.WebAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly BlogManager _blogManager;
        private readonly NavitemManager _navitemManager;
        private readonly LoginManager _logInManager;

        public HomeController(IBlogDal blogsDal, ICategoryDal categoryDal, INavitemDal navitemDal, ILoginDal loginDal, IUserDal userDal, IMembershipsDal membershipsDal)
        {
            _blogManager = new BlogManager(blogsDal, categoryDal, null);
            _navitemManager = new NavitemManager(navitemDal);
            _logInManager = new LoginManager(loginDal, userDal, membershipsDal);
        }

        [HttpGet]
        public async Task<IActionResult> Index(int page)
        {
            ViewBag.navitems = await _navitemManager.GetAllAsync();

            var blogs = await _blogManager.GetAllAsync(page, 12);

            if (!blogs.Any()) return BadRequest();
            
            ViewBag.page = page;
            ViewBag.ipages =
                Math.Ceiling(
                    await _blogManager.GetRowCountAsync()  / (float)12
                );
            
            return View(new HomeViewModel
            {
                Blogs = blogs
            });
            

        }

        [HttpGet]
        public async Task<IActionResult> LogIn()
        {
            ViewBag.navitems = await _navitemManager.GetAllAsync();

            return View(new LogInViewModel());
        }
        
        [HttpPost]
        public async Task<IActionResult> LogIn(UiLogin login)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.navitems = await _navitemManager.GetAllAsync();
                return View(new LogInViewModel());
            }

            if (await _logInManager.LogIn(login)) return RedirectToAction("Index", "Home");
            
            return BadRequest();
        }
        
        [HttpGet]
        public async Task<IActionResult> SingUp()
        {
            ViewBag.navitems = await _navitemManager.GetAllAsync();

            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SingUp(UiUser user, UiLogin login, UiMemberships membership)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.navitems = await _navitemManager.GetAllAsync();
                
                return View();
            }
            
            var result = await _logInManager.SingUp( login, user, membership);
            
            if (result) return await LogIn();
            
            
            return BadRequest();
        }
    }
}
