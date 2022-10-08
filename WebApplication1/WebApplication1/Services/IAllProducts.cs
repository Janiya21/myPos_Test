using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IAllProducts
    {
        public JsonResult GetProduct();

        public JsonResult AddProduct(Product product);

        public JsonResult UpdateProduct(Product customer);

        public JsonResult DeleteProduct(string id);
    }
}
