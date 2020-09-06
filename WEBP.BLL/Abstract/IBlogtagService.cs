using System;
using System.Collections.Generic;
using System.Text;
using WEBP.Entities;

namespace WEBP.BLL.Abstract
{
    public interface IBlogtagService
    {
        List<int> GetTagIdByBlog(Blog blog);
        List<int> GetBlogIdByTag(Tag tag);
        void AddTagToBlog(Blog blog, Tag tag);
        void DeleteTagFromBlog(Blog blog, Tag tag);
    }
}
