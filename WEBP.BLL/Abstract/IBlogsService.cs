using System;
using System.Collections.Generic;
using System.Text;
using WEBP.Entities;

namespace WEBP.BLL.Abstract
{
    public interface IBlogsService
    {
        List<Blogs> GetAll();
        void Add(Blogs blog);
        void Update(Blogs blog);
        void Delete(int blogId);
        Blogs GetById(int blogId);
    }
}
