using System.Collections.Generic;
using System.Threading.Tasks;
using WEBP.BLL.Abstract;
using WEBP.DAL.Interfaces;
using WEBP.Entities.Database;
using WEBP.Entities.UI;

namespace WEBP.BLL.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public async Task<bool> AddAsync(Category category)
        {
            return await _categoryDal.AddAsync(category);
        }

        public async Task<Category> GetByNameAsync(string categoryName)
        {
            return await _categoryDal.GetAsync(c => c.postcolor == categoryName);
        }

        public async Task<bool> DeleteAsync(string categoryName)
        {
           return await _categoryDal.DeleteAsync(
                  await _categoryDal.GetAsync(c => c.name == categoryName));
        }

        public async Task<List<UiCategory>> GetAllAsync()
        {
            List<Category> categorys = await _categoryDal.GetListAsync();
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

        public async Task< List<Category> > GetAllWithIdAsync() => await _categoryDal.GetListAsync();

        public async Task<bool> UpdateAsync(Category category) => await _categoryDal.UpdateAsync(category);
    }
}
