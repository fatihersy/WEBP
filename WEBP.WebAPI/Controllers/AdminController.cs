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
        private readonly ProductManager _productManager;
        public AdminController(IProductDal productsDal)
        {
            _productManager = new ProductManager(productsDal);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new CreatePanelViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( UiProduct blog )
        {
            if (!ModelState.IsValid)
            {
                return View(new CreatePanelViewModel());
            }

            var instance = new Product
            {
                Title = blog.Title,
                UserId = 1,
                UniqueId = Guid.NewGuid()
            };
            
            if ( await _productManager.AddAsync(instance))
                return View();
            else
                return BadRequest();
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            return View(new ListPanelViewModel
            {
                Products = await _productManager.GetAllWithIdAsync()
            });
        }
        
    }
}
