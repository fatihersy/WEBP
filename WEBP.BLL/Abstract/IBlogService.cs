using System.Collections.Generic;
using WEBP.Entities.Database;
using WEBP.Entities.UI;

namespace WEBP.BLL.Abstract
{
    public interface IBlogService
    {
        List<UiBlog> GetAll();
        void Add(Blog blog);
        void Update(Blog blog);
        void Delete(int blogId);
        UiBlog GetById(int blogId);
    }
}
