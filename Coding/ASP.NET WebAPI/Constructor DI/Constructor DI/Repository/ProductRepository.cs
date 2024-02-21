using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Constructor_DI.Repository
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<Product> GetAll()
        {
            return new List<Product>()
            {
                new Product { Id = 1,Name = "TV",price= 1000},
                new Product { Id = 2, Name = "Fridge", price = 2000 },
                new Product { Id = 3,Name ="AC", price = 3000}

            };

            

            
        }

    }
}