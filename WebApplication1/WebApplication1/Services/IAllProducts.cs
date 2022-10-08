using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IAllProducts
    {
        public List<Product> GetProduct();

        public Product AddProduct(Product product);

        public Product UpdateProduct(string id, Product customer);

        public string DeleteProduct(string id);
    }
}
