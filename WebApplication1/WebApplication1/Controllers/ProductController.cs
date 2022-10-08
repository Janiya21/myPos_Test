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
        public List<Models.Product> list = new List<Models.Product>();
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
            string connectionString = "Data Source=.;Initial Catalog=test_db;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("fucker get");
                connection.Open();
                string sql = "Select * from Product";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product invoiceList = new Product();
                            invoiceList.Products_id = reader.GetInt32(0);
                            invoiceList.Product_Name = reader.GetString(1);
                            invoiceList.Products_price = reader.GetString(2);
                            invoiceList.Products_qty = reader.GetInt32(3);

                            list.Add(invoiceList);
                        }
                    }
                }
            }
            return new JsonResult(JsonConvert.DeserializeObject(JsonConvert.SerializeObject(list)));
        }

        [HttpPost("post")]
        public ActionResult<Product> AddProduct(Product product)
        {
            Console.WriteLine(product.Product_Name);
            Console.WriteLine("fucker post");
            Product product1 = _productService.AddProduct(product);

            string connectionString = "Data Source=.;Initial Catalog=test_db;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var mycommand = new SqlCommand("INSERT INTO Product VALUES(@Products_id, @Product_Name, @Products_price, @Products_price)",
                               connection);

                mycommand.Parameters.AddWithValue("@Products_id", product.Products_id);
                mycommand.Parameters.AddWithValue("@Product_Name", product.Product_Name);
                mycommand.Parameters.AddWithValue("@Products_price", product.Products_price);
                mycommand.Parameters.AddWithValue("@Products_qty", product.Products_qty);
                mycommand.ExecuteNonQuery();
            }

            return product;
        }

    }
}
