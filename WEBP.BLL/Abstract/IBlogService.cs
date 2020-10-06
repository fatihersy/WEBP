using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WEBP.Entities.Database;
using WEBP.Entities.UI;

namespace WEBP.BLL.Abstract
{
    public interface IBlogService
    {
        Task<List<Blog>> GetAllWithIdAsync();

        Task<List<UiBlog>> GetAllAsync(int skip, int take);

        Task<List<UiBlog>> GetAllAsync();

        Task<bool> AddAsync(Blog blog);

        Task<bool> UpdateAsync(Blog blog);

        Task<bool> DeleteAsync(Guid blogId);

        Task<int> GetRowCountAsync();

        Task<UiBlog> GetByIdAsync(Guid blogId);
    }
}
