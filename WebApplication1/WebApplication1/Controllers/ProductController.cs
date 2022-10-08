using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProdctController : ControllerBase
    {
        private ILogger _logger;
        private IAllProducts _productService;

        public ProdctController(ILogger<ProdctController> logger, IAllProducts productService)
        {
            _logger = logger;
            _productService = productService;
        }

        [HttpGet("getAll")]
        public JsonResult OnGet()
        {
            return _productService.GetProduct(); ;
        }

        [HttpPost("post")]
        public JsonResult AddProduct(Product product)
        {
            return _productService.AddProduct(product);
        }

        [HttpDelete("delete/{id}")]
        public JsonResult DeleteProduct(String id)
        {
            Console.WriteLine(id);
            return _productService.DeleteProduct(id); ;
        }

        [HttpPut("put")]
        public JsonResult UpdateProduct(Product p)
        {
            Console.WriteLine(p.Products_id);
            return _productService.UpdateProduct(p);
        }

    }
}
