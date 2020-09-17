using System;
using System.Collections.Generic;
using System.Text;
using WEBP.Core.EntityRepositories;
using WEBP.DAL.Interfaces;
using WEBP.Entities.Database;

namespace WEBP.DAL.Concrete.EntityFramework
{
    public class EfNavitemDal : EfEntityRepositoryBase<Navitem, MineDbContext>, INavitemDal
    {

    }
}
