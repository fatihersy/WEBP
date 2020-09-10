using System.Collections.Generic;
using WEBP.BLL.Abstract;
using WEBP.DAL.Interfaces;
using WEBP.Entities.UI;
using WEBP.Entities.Database;

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

        public List<UiCategory> GetAll()
        {
            List<Category> categorys = _categoryDal.GetList();
            List<UiCategory> uiCategorys = new List<UiCategory>();

            foreach (var item in categorys)
            {
                UiCategory uiCategory = new UiCategory
                {
                    name = item.name,
                    postcolor = item.postcolor
                };

                uiCategorys.Add(uiCategory);
            }

            return uiCategorys;
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
