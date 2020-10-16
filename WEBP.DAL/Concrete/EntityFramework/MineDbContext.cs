using Microsoft.EntityFrameworkCore;
using WEBP.Entities.Database;

namespace WEBP.DAL.Concrete.EntityFramework
{
    public class MineDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user id=root;password=Fatih.ersy97;database=minedb;persistsecurityinfo=True");
        }

        public DbSet<Blog> Blog { get; set; }

        public DbSet<Author> Author { get; set; }

        public DbSet<Tag> Tag { get; set; }

        public DbSet<Blogtag> Blogtag { get; set; }

        public DbSet<Category> Category { get; set; }

        public DbSet<Navitem> Navitem { get; set; }

        public DbSet<User> User { get; set; }

        public DbSet<Login> Login { get; set; }

        public DbSet<Memberships> Memberships { get; set; }

    }
}
