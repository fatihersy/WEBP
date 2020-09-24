using System.Collections.Generic;
using WEBP.BLL.Abstract;
using WEBP.DAL.Interfaces;
using WEBP.Entities.UI;
using WEBP.Entities.Database;
using System.Linq;

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

        public int GetRowCount() => _blogDal.GetList().Count();

        public void Add(Blog blog)
        {
            _blogDal.Add(blog);
        }

        public void Delete(int blogId)
        {
            _blogDal.Delete( new Blog{ id = blogId } );
        }

        public List<UiBlog> GetAll(int page, int pageSize)
        {
            if (page < 1) page = 0;
            else page--;
            page = page * pageSize;

            List<Blog> blogs = _blogDal.GetList().Skip(page).Take(pageSize).ToList();
            List<UiBlog> uiBlogs = new List<UiBlog>();

            foreach (var item in blogs)
            {
                UiBlog uiBlog = new UiBlog
                {
                    title = item.title,
                    category = _categoryDal.Get(c => c.id == item.categoryid).name,
                    uniqueid = item.uniqueid
                };

                uiBlogs.Add(uiBlog);
            }

            return uiBlogs;
        }

        public UiBlog GetById(string blogId)
        {
            Blog blog = _blogDal.Get(a => a.uniqueid == blogId);

            return new UiBlog
            {
                title = blog.title,
                content = blog.content,
                category = _categoryDal.Get(c => c.id == blog.categoryid).name,
                author = _authorDal.Get(a => a.id == blog.authorId).name
            };
        }

        public void Update(Blog blog)
        {
            _blogDal.Update(blog);
        }
    }
}
