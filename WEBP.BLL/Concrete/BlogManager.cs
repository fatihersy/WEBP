using System.Collections.Generic;
using WEBP.BLL.Abstract;
using WEBP.DAL.Interfaces;
using WEBP.Entities.UI;
using WEBP.Entities.Database;

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

        public void Add(Blog blog)
        {
            _blogDal.Add(blog);
        }

        public void Delete(int blogId)
        {
            _blogDal.Delete( new Blog{ id = blogId } );
        }

        public List<UiBlog> GetAll()
        {
            List<Blog> blogs = _blogDal.GetList();
            List<Category> categorys = _categoryDal.GetList();
            List<Author> authors = _authorDal.GetList();
            List<UiBlog> uiBlogs = new List<UiBlog>();

            foreach (var item in blogs)
            {
                Category category = categorys.Find(c => c.id == item.categoryid);

                UiBlog uiBlog = new UiBlog
                {
                    title = item.title,
                    description = item.description,
                    category = category.name,
                    postcolor = category.postcolor,
                    author = authors.Find(a => a.id == item.authorId).name,
                };

                uiBlogs.Add(uiBlog);
            }

            return uiBlogs;
        }

        public UiBlog GetById(int blogId)
        {
            Blog blog = _blogDal.Get(a => a.id == blogId);

            return new UiBlog
            {
                title = blog.title,
                description = blog.description,
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
