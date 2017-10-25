using System;
namespace app.Models
{
    public class Product
    {
        public Product()
        {}

        public Product(string name, string description, int price)
        {
            
            this.Name = name;
            this.Description = description;
            this.Price = price;             
        }

        public int ID
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public int Price
        {
            get;
            set;
        }

    }
}
