using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Context
{
    public class AppDbContext:DbContext
    {
        DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product{Id = Guid.NewGuid(),Name="Kitap",Quantity=150,Value=12,CreateDate=DateTime.Now,},
                new Product{Id = Guid.NewGuid(),Name="Buzdolabı",Quantity=6,Value=1500,CreateDate=DateTime.Now,},
                new Product{Id = Guid.NewGuid(),Name="Gardrop",Quantity=4,Value=1700,CreateDate=DateTime.Now,}
                );
        }
    }
}
