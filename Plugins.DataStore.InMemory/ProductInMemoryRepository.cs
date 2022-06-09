using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class ProductInMemoryRepository : IProductRepository
    {
        private List<Product> products;

        public ProductInMemoryRepository()
        {
            //Default Values
            products = new List<Product>()
            {
                new Product {ProductId =1, CategoryId = 1, Name = "Iced Tea", Quantity=100, Price = 2000},
                new Product {ProductId =2, CategoryId = 1, Name = "Ginger Ale", Quantity=200, Price = 3000},
                new Product {ProductId =3, CategoryId = 2, Name = "Bread", Quantity=50, Price = 800},
                new Product {ProductId =4, CategoryId = 2, Name = "Pastry", Quantity=10, Price = 900},
            };
        }

        public IEnumerable<Product> GetProducts()
        {
            return products;
        }
    }
}
