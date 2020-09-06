using System;
using System.Collections.Generic;
using System.Text;
using WEBP.Entities;

namespace WEBP.BLL.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        void Add(Category category);
        void Update(Category category);
        void Delete(string categoryName);
    }
}
