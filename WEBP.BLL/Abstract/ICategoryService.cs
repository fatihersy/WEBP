using System.Collections.Generic;
using System.Threading.Tasks;
using WEBP.Entities.Database;
using WEBP.Entities.UI;

namespace WEBP.BLL.Abstract
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAllWithIdAsync();
        Task<List<UiCategory>> GetAllAsync();
        Task<bool> AddAsync(Category category);
        Task<bool> UpdateAsync(Category category);
        Task<bool> DeleteAsync(string categoryName);
    }
}
