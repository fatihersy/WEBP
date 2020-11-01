using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using WEBP.BLL.Concrete;
using WEBP.DAL.Interfaces;
using WEBP.WebAPI.Models;

namespace WEBP.WebAPI.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductManager _productManager;

        public ProductController(IProductDal productsDal)
        {
            _productManager = new ProductManager(productsDal);
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
        public async Task<IActionResult> Search(string q)
        {
            return View(new SearchViewModel
            {
                Products = await _productManager.GetByQueryAsync(q)
            });
        }
    }
}
