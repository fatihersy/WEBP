using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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
        private readonly IUserDal _userDal;
        public ProductManager(IProductDal productDal, IUserDal userDal)
        {
            _userDal = userDal;
            _productDal = productDal;
        }

        private static async Task<List<TResult>> SelectAsync<TSource, TResult>
            (
                IEnumerable<TSource> source, 
                Func<TSource, Task<TResult>> selector
            )
        {
            // EXCEPTION HANDLER
                if (source == null) { throw new ArgumentNullException(nameof(source)); }
                if (selector == null) { throw new ArgumentNullException(nameof(selector));}
            // EXCEPTION HANDLER 
            
            return ( await Task.WhenAll(source.Select(selector)) ).ToList();
        }
        
        public async Task<List<UiProduct>> GetAllWithSizeAsync(int page, int pageSize)
        {
            if (page < 1) page = 1;
            if (pageSize < 1) pageSize = 1;
            page--;
            page *= pageSize;
            
            var products = await _productDal.GetListAsync(pageSize, page, p => p.IsActive);

            return await SelectAsync(products, async p => 
                new UiProduct
                {
                    Title =           p.Title,
                    Price =           p.Price,
                    DiscountedPrice = p.Price,
                    UniqueId =        p.UniqueId,
                    User = ( await _userDal.GetAsync(u => u.Id == p.UserId ) ).UserName
                });
        }

        public async Task<List<UiProduct>> GetAllAsync()
        {
            var products = await _productDal.GetListAsync(p => p.IsActive);

            return products.Select(async p => 
                new UiProduct
                {
                    Title =           p.Title,
                    Price =           p.Price,
                    DiscountedPrice = p.Price,
                    UniqueId =        p.UniqueId,
                    User = ( await _userDal.GetAsync(u => u.Id == p.UserId ) ).UserName
                }).Select(p => p.Result).ToList();
        }

        public async Task<UiProduct> GetByIdAsync(Guid productId)
        {
            var product = await _productDal.GetAsync(p => p.UniqueId == productId && p.IsActive );

            return new UiProduct
            {
                Title =           product.Title,
                Price =           product.Price,
                Description =     product.Description,
                DiscountedPrice = product.Price,
                UniqueId =        product.UniqueId,
                User = ( await _userDal.GetAsync(u => u.Id == product.UserId ) ).UserName
            };
        }
        
        public async Task<List<UiProduct>> GetByQueryAsync(string q)
        {
            var cleanQuery = Regex.Replace(q, @"(^\s+)|(\s+$)", "");
            cleanQuery = Regex.Replace(cleanQuery, @"\s+", " ");

            var products = await _productDal.GetListAsync(p => p.Title.Contains(cleanQuery) && p.IsActive);
                
            return products.Select(async p =>
                new UiProduct
                {
                    Title = p.Title,
                    Price = p.Price,
                    DiscountedPrice = p.Price,
                    User = ( await _userDal.GetAsync(u => u.Id == p.UserId ) ).UserName,
                    UniqueId = p.UniqueId
                }).Select(t => t.Result).ToList();
        }


        public async Task<bool> AddAsync(Product product) => await _productDal.AddAsync(product);

        public async Task<bool> UpdateAsync(Product product) => await _productDal.UpdateAsync(product);

        public async Task<bool> DeleteAsync(Guid productId) => await _productDal.UpdateAsync(new Product { UniqueId = productId, IsActive = false});
        public async Task<List<Product>> GetAllWithIdAsync() => await _productDal.GetListAsync();
        public async Task<int> GetRowCountAsync() => await _productDal.GetRowCountAsync();
    }
}
