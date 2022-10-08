using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data.SqlClient;
using System;
using Newtonsoft.Json;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProdctController : ControllerBase
    {
        public List<Models.Product> list = new List<Models.Product>();

        [HttpGet]
        public JsonResult OnGet()
        {
            string connectionString = "Data Source=.;Initial Catalog=test_db;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
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
    }
}
