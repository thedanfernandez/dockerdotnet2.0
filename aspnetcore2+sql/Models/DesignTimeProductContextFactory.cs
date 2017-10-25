using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace app.Models
{
    /// <summary>
    /// Added for command line generation
    /// </summary>
    public class DesignTimeProductContextFactory : IDesignTimeDbContextFactory<ProductContext>
    {
        /* Run this command
          
         dotnet aspnet-codegenerator controller --force --controllerName ProductsController --model aspnet2vsmacplay.Models.Product --dataContext  aspnet2vsmacplay.Models.ProductContext --relativeFolderPath Controllers --controllerNamespace aspnet2vsmacplay.Controllers --useDefaultLayout

        */
        public DesignTimeProductContextFactory()
        {

        }

        public ProductContext CreateDbContext(string[] args)
        {
            ///change later
            //IConfigurationRoot configuration = new ConfigurationBuilder()
            //.SetBasePath(Directory.GetCurrentDirectory())
            //.AddJsonFile("appsettings.json")
            //.Build();
            //var connectionString = configuration.GetConnectionString("DefaultConnection");

            var builder = new DbContextOptionsBuilder<ProductContext>();

            //builder.UseSqlite("Data Source=Products.db");
            builder.UseSqlServer(@"Server=(local);Database=Products;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new ProductContext(builder.Options);
        }
    }
}
