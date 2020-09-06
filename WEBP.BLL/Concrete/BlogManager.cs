using System.Collections.Generic;
using WEBP.BLL.Abstract;
using WEBP.DAL.Interfaces;
using WEBP.Entities;

namespace WEBP.BLL.Concrete
{
    public class BlogManager : IBlogService
    {
        private IBlogDal _blogsDal;
        public BlogManager(IBlogDal blogsDal)
        {
            _blogsDal = blogsDal;
        }

        public void Add(Blog blog)
        {
            _blogsDal.Add(blog);
        }

        public void Delete(int blogId)
        {
            _blogsDal.Delete( new Blog{ id = blogId } );
        }

        public List<Blog> GetAll()
        {
            return _blogsDal.GetList();
        }

        public Blog GetById(int blogId)
        {
            return _blogsDal.Get(b => b.id == blogId);
        }

        public void Update(Blog blog)
        {
            _blogsDal.Update(blog);
        }
    }
}
