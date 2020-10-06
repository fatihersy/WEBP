using System.Collections.Generic;
using System.Threading.Tasks;
using WEBP.Entities.Database;
using WEBP.Entities.UI;

namespace WEBP.BLL.Abstract
{
    public interface INavitemService
    {
        Task< List<UiNavitem> > GetAllAsync();

        Task<bool> AddAsync(Navitem navitem);

        Task<bool> UpdateAsync(Navitem navitem);

        Task<bool> DeleteAsync(Navitem navitem);

        Task<UiNavitem> GetByNameAsync(string name);
    }
}
