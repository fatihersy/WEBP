using System;
using System.Collections.Generic;
using System.Text;
using WEBP.BLL.Abstract;
using WEBP.DAL.Interfaces.EntityFramework;
using WEBP.Entities;

namespace WEBP.BLL.Concrete
{
    public class BlogsManager : IBlogsService
    {
        private IBlogsDal _blogsDal;
        public BlogsManager(IBlogsDal blogsDal)
        {
            _blogsDal = blogsDal;
        }

        public void Add(Blogs blog)
        {
            _blogsDal.Add(blog);
        }

        public void Delete(int blogId)
        {
            _blogsDal.Delete( new Blogs{ id = blogId } );
        }

        public List<Blogs> GetAll()
        {
            return _blogsDal.GetList();
        }

        public Blogs GetById(int blogId)
        {
            return _blogsDal.Get(b => b.id == blogId);
        }

        public void Update(Blogs blog)
        {
            _blogsDal.Update(blog);
        }
    }
}
