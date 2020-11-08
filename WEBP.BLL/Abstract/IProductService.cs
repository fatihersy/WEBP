using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WEBP.Entities.Database;
using WEBP.Entities.UI;

namespace WEBP.BLL.Abstract
{
    public interface IProductService
    {
        Task<List<Product>> GetAllWithIdAsync();

        Task<List<UiProduct>> GetAllWithSizeAsync(int skip, int take);

        Task<List<UiProduct>> GetAllAsync();

        Task<bool> AddAsync(Product product);

        Task<bool> UpdateAsync(Product product);

        Task<bool> DeleteAsync(Guid productId);

        Task<int> GetRowCountAsync();

        Task<UiProduct> GetByIdAsync(Guid productId);

        Task<List<UiProduct>> GetByQueryAsync(string q);
    }
}
