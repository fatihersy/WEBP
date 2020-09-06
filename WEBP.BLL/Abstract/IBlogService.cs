using System.Collections.Generic;
using WEBP.Entities;

namespace WEBP.BLL.Abstract
{
    public interface IBlogService
    {
        List<Blog> GetAll();
        void Add(Blog blog);
        void Update(Blog blog);
        void Delete(int blogId);
        Blog GetById(int blogId);
    }
}
