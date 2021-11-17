using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPractice.Models
{
    public class Warehouse
    {
        public static void Initialize(ProductContext context)
        {
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "iPhone X",
                        Description = "Apple",
                        Price = 14999
                    },
                    new Product
                    {
                        Name = "Samsung Galaxy Edge",
                        Description = "Samsung",
                        Price = 12999
                    },
                    new Product
                    {
                        Name = "Pixel 3",
                        Description = "Google",
                        Price = 11999
                    }
                );
                context.SaveChanges();

            }
        }
    }
}
