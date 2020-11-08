using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using WEBP.BLL.Concrete;
using WEBP.DAL.Interfaces;
using WEBP.WebAPI.Models;

namespace WEBP.WebAPI.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductManager _productManager;

        public ProductController(IProductDal productDal, IUserDal userDal)
        {
            _productManager = new ProductManager(productDal, userDal);
        }

        [HttpGet]
        public async Task<IActionResult> Index(Guid id)
        {
            return View(new ProductViewModel
            {
                Product = await _productManager.GetByIdAsync(id)
            });
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Search(string q)
        {
            if (q == null) return RedirectToAction("Index", "Home");
            
            var products = await _productManager.GetByQueryAsync(q);
            
            if (products.Any())
                return View(new SearchViewModel
                {
                    Products = products
                });
            else return BadRequest();
        }
    }
}
