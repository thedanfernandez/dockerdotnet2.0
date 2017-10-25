using System;
using Microsoft.EntityFrameworkCore;

namespace app.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base (options)
        {
        }

        public ProductContext()
        {
            
        }

        public DbSet<Product> Products { get; set; }

    }
}
