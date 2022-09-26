using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient.Memcached;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        public List<Models.Invoice> list = new List<Models.Invoice>();

        [HttpGet]
        public JsonResult OnGet()
        {
            string connectionString = "Data Source=.;Initial Catalog=test_db;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "Select * from Invoice_Hed";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Invoice invoiceList = new Invoice();
                            invoiceList.Invoice_Head_id = reader.GetInt16(0);
                            invoiceList.Invoice_Head_Customer = reader.GetString(1);
                            invoiceList.Invoice_Head_Amount = reader.GetString(2);
                            invoiceList.Invoice_Head_Date = reader.GetDateTime(3);

                            list.Add(invoiceList);
                        }
                    }
                }
            }
            return new JsonResult( JsonConvert.DeserializeObject(JsonConvert.SerializeObject(list)));
        }
    }
}
