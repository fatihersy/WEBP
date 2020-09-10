using System.Collections.Generic;
using WEBP.BLL.Abstract;
using WEBP.DAL.Interfaces;
using WEBP.Entities.UI;
using WEBP.Entities.Database;

namespace WEBP.BLL.Concrete
{
    public class BlogtagManager : IBlogtagService
    {
        private IBlogtagDal _blogtagDal;
        public BlogtagManager(IBlogtagDal blogtagDal)
        {
            _blogtagDal = blogtagDal;
        }

        public void AddTagToBlog(Blog blog, Tag tag)
        {
            _blogtagDal
                .Add( new Blogtag
                {
                    tagid = tag.id,
                    blogid = blog.id
                });
        }

        public void DeleteTagFromBlog(Blog blog, Tag tag)
        {
            _blogtagDal.Delete(
                        _blogtagDal.Get(bt => bt.blogid == blog.id && bt.tagid == tag.id )
            );
        }

        public List<int> GetTagIdByBlog(Blog blog)
        {
            List<int> tagIds = null;

            _blogtagDal
                .GetList(bt => bt.blogid == blog.id)
                .ForEach(bt => tagIds.Add(bt.blogid));

            return tagIds;
        }

        public List<int> GetBlogIdByTag(Tag tag)
        {
            List<int> blogIds = null;

            _blogtagDal
                .GetList(bt => bt.blogid == tag.id)
                .ForEach(bt => blogIds.Add(bt.blogid));

            return blogIds;
        }
    }
}
