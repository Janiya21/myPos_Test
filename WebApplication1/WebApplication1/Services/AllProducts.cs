using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class AllProducts : IAllProducts
    {

        private List<Product> _product;

        public AllProducts()
        {
            _product = new List<Product>();
        }

        public Product AddProduct(Product product)
        {
            _product.Add(product);
            return product;
        }

        public string DeleteProduct(string id)
        {
            throw new System.NotImplementedException();
        }

        public List<Product> GetProduct()
        {
            throw new System.NotImplementedException();
        }

        public Product UpdateProduct(string id, Product customer)
        {
            throw new System.NotImplementedException();
        }
    }
}
