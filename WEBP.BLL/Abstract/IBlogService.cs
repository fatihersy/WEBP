using System.Collections.Generic;
using System.Reflection.Metadata;
using WEBP.Entities.Database;
using WEBP.Entities.UI;

namespace WEBP.BLL.Abstract
{
    public interface IBlogService
    {
        List<UiBlog> GetAll(int skip, int take);
        int GetRowCount();
        void Add(Blog blog);
        void Update(Blog blog);
        void Delete(int blogId);
        UiBlog GetById(string blogId);
    }
}
