using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBP.BLL.Abstract;
using WEBP.DAL.Interfaces;
using WEBP.Entities.Database;
using WEBP.Entities.UI;

namespace WEBP.BLL.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;
        public ProductManager(IProductDal productsDal)
        {
            _productDal = productsDal;
        }

        public async Task<List<UiProduct>> GetAllAsync(int page, int pageSize)
        {
            if (page < 1) page = 1;
            page--;
            page *= pageSize;

            var products = await _productDal.GetListAsync(pageSize, page);

            return products.Select(item => 
                new UiProduct
                {
                    Title = item.Title,
                    UniqueId = item.UniqueId
                }).ToList();
        }

        public async Task<List<UiProduct>> GetAllAsync()
        {
            var products = await _productDal.GetListAsync();

            return products.Select(item => 
                new UiProduct
                {
                    Title = item.Title,
                    UniqueId = item.UniqueId
                }).ToList();
        }

        public async Task<UiProduct> GetByIdAsync(Guid productId)
        {
            var product = await _productDal.GetAsync(a => a.UniqueId == productId);

            return new UiProduct
            {
                Title = product.Title,
                Description = product.Description
            };
        }
        
        public async Task<IEnumerable<UiProduct>> GetByQueryAsync(string q)
        {
            var keys = q.Split("-");
            
            //TODO Veritabanından veri çekmek için expression yazılacak
            var products = await _productDal.GetListAsync();

            return products.Select(p =>
                new UiProduct
                {
                    Title = p.Title,
                    UniqueId = p.UniqueId
                });
        }


        public async Task<bool> AddAsync(Product product) => await _productDal.AddAsync(product);

        public async Task<bool> UpdateAsync(Product product) => await _productDal.UpdateAsync(product);

        public async Task<bool> DeleteAsync(Guid productId) => await _productDal.DeleteAsync(new Product { UniqueId = productId });
        public async Task<List<Product>> GetAllWithIdAsync() => await _productDal.GetListAsync();
        public async Task<int> GetRowCountAsync() => await _productDal.GetRowCountAsync();
    }
}
