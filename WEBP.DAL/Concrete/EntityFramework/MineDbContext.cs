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

        public DbSet<Blogs> Blogs { get; set; }
    }
}
