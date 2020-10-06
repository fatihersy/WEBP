using System.Collections.Generic;
using System.Threading.Tasks;
using WEBP.Entities.Database;
using WEBP.Entities.UI;

namespace WEBP.BLL.Abstract
{
    public interface IAuthorService
    {
        Task<List<Author>> GetAllWithIdAsync();
        Task<List<UiAuthor>> GetAllAsync();
        Task<bool> AddAsync(Author authors);
        Task<bool> UpdateAsync(Author authors);
        Task<bool> DeleteAsync(Author authors);
        Task<UiAuthor> GetAuthorByEmailAsync(Author authors);
    }
}
