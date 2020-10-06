using System.Collections.Generic;
using System.Threading.Tasks;
using WEBP.Entities.Database;
using WEBP.Entities.UI;

namespace WEBP.BLL.Abstract
{
    public interface ITagService
    {
        Task< List<UiTag> > GetAllAsync();
        Task<bool> AddAsync(Tag tag);
        Task<bool> UpdateAsync(Tag tag);
        Task<bool> DeleteAsync(Tag tag);
        Task<UiTag> GetTagByNameAsync(Tag tag);
    }
}
