using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace app
{
    public class DbInitializer
    {
        public static void Initialize(Models.ProductContext context)
        {
            context.Database.EnsureCreated();

            if (context.Products.Count() == 0)
            {
                //add fake products
                var newProducts = new List<Models.Product>(){
                new Models.Product(name: "Book 1", description: "First Book", price: 10),
                new Models.Product(name: "Book 2", description: "Second Book", price: 20),
                new Models.Product(name: "Book 3", description: "Third Book", price: 30)};

                foreach (var p in newProducts)
                {
                    context.Products.Add(p);
                }
                context.SaveChanges();
            }

        }

    }
}