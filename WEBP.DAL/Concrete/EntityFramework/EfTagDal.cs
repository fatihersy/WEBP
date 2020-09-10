using WEBP.Core.EntityRepositories;
using WEBP.DAL.Interfaces;
using WEBP.Entities.Database;

namespace WEBP.DAL.Concrete.EntityFramework
{
    public class EfTagDal : EfEntityRepositoryBase<Tag, MineDbContext>, ITagDal
    {
    }
}
