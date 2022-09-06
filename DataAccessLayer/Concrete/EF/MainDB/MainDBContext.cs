using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EF.MainDB
{
    public class MainDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=db;User ID=sa;Password=1234;MultipleActiveResultSets=true");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category[] {
                new Category{CategoryId = 1, CategoryName="Yiyecekler"},
                new Category{CategoryId = 2,CategoryName="İçecekler"},
                new Category{CategoryId = 3,CategoryName="Sütlü Tatlılar"},
                new Category{CategoryId = 4,CategoryName="Soğuk Tatlılar"},
                new Category{CategoryId = 5,CategoryName="Meyveler"},
                new Category{CategoryId = 6,CategoryName="Ara Sıcaklar"},

            });
        }
    }
}
