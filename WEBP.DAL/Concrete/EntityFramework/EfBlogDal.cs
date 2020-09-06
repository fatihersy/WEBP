using WEBP.Core.EntityRepositories;
using WEBP.DAL.Interfaces;
using WEBP.Entities;

namespace WEBP.DAL.Concrete.EntityFramework
{
    public class EfBlogDal : EfEntityRepositoryBase<Blog, MineDbContext>, IBlogDal
    {

    }
}
