using System;
using System.Collections.Generic;
using System.Text;
using WEBP.BLL.Abstract;
using WEBP.DAL.Interfaces;
using WEBP.Entities;

namespace WEBP.BLL.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Delete(string categoryName)
        {
            _categoryDal.Delete(
                _categoryDal.Get(   c => c.name == categoryName )
            );
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
