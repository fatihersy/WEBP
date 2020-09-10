using System.Collections.Generic;
using WEBP.Entities.Database;
using WEBP.Entities.UI;

namespace WEBP.BLL.Abstract
{
    public interface ICategoryService
    {
        List<UiCategory> GetAll();
        void Add(Category category);
        void Update(Category category);
        void Delete(string categoryName);
    }
}
