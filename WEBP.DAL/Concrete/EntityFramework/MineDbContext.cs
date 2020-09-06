using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using WEBP.Entities;

namespace WEBP.DAL
{
    public class MineDbContext:DbContext
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
    }
}
