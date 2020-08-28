using System;
using System.Collections.Generic;
using System.Text;
using WEBP.Core.EntityRepositories;
using WEBP.DAL.Interfaces.EntityFramework;
using WEBP.Entities;

namespace WEBP.DAL.Concrete.EntityFramework
{
    public class EfBlogsDal : EfEntityRepositoryBase<Blogs, MineDbContext>, IBlogsDal
    {

    }
}
