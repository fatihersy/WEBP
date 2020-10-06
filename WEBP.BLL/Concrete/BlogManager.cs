using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WEBP.BLL.Abstract;
using WEBP.DAL.Interfaces;
using WEBP.Entities.Database;
using WEBP.Entities.UI;

namespace WEBP.BLL.Concrete
{
    public class BlogManager : IBlogService
    {
        private IBlogDal _blogDal;
        private ICategoryDal _categoryDal;
        private IAuthorDal _authorDal;
        public BlogManager(IBlogDal blogsDal, ICategoryDal categoryDal, IAuthorDal authorDal)
        {
            _blogDal = blogsDal;
            _categoryDal = categoryDal;
            _authorDal = authorDal;
        }

        public async Task<List<UiBlog>> GetAllAsync(int page, int pageSize)
        {
            if (page < 1) page = 0;
            else page--;
            page = page * pageSize;

            List<Blog> blogs = await _blogDal.GetListAsync(pageSize, page);
            List<Category> categories = await _categoryDal.GetListAsync();
            List<UiBlog> uiBlogs = new List<UiBlog>();

            foreach (var item in blogs)
            {
                UiBlog uiBlog = new UiBlog
                {
                    title = item.title,
                    category = categories.Find(c => c.id == item.categoryid).name,
                    uniqueid = item.uniqueid
                };

                uiBlogs.Add(uiBlog);
            }

            return uiBlogs;
        }

        public async Task<List<UiBlog>> GetAllAsync()
        {
            List<Blog> blogs = await _blogDal.GetListAsync();
            List<Category> categories = await _categoryDal.GetListAsync();
            List<UiBlog> uiBlogs = new List<UiBlog>();

            foreach (var item in blogs)
            {
                UiBlog uiBlog = new UiBlog
                {
                    title = item.title,
                    category = categories.Find(c => c.id == item.categoryid).name,
                    uniqueid = item.uniqueid
                };

                uiBlogs.Add(uiBlog);
            }

            return uiBlogs;
        }

        public async Task<UiBlog> GetByIdAsync(Guid blogId)
        {
            Blog blog = await _blogDal.GetAsync(a => a.uniqueid == blogId);

            return new UiBlog
            {
                title = blog.title,
                content = blog.content,
                category = ( await _categoryDal.GetAsync(c => c.id == blog.categoryid)).name,
                author = ( await _authorDal.GetAsync(a => a.id == blog.authorId)).name
            };
        }


        public async Task<bool> AddAsync(Blog blog) => await _blogDal.AddAsync(blog);

        public async Task<bool> UpdateAsync(Blog blog) => await _blogDal.UpdateAsync(blog);

        public async Task<bool> DeleteAsync(Guid blogId) => await _blogDal.DeleteAsync(new Blog { uniqueid = blogId });

        public async Task<List<Blog>> GetAllWithIdAsync() => await _blogDal.GetListAsync();

        public async Task<int> GetRowCountAsync() => await _blogDal.GetRowCountAsync();
    }
}
