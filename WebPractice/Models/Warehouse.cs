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
                        Name = "Шашлык",
                        Description = "Вертел",
                        Price = 299
                    },
                    new Product
                    {
                        Name = "Пивандрий",
                        Description = "Хмельнов",
                        Price = 149
                    },
                    new Product
                    {
                        Name = "Хычин",
                        Description = "Класс",
                        Price = 250
                    }
                );
                //context.SaveChanges();

            }
        }
    }
}
