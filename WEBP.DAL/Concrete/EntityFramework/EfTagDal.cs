using System;
using System.Collections.Generic;
using System.Text;
using WEBP.Core.EntityRepositories;
using WEBP.DAL.Interfaces;
using WEBP.Entities;

namespace WEBP.DAL.Concrete.EntityFramework
{
    public class EfTagDal : EfEntityRepositoryBase<Tag, MineDbContext>, ITagDal
    {
    }
}
