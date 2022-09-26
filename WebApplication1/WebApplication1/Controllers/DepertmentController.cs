using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient.Memcached;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        public List<Models.Invoice> list = new List<Models.Invoice>();

        public void OnGet()
        {
            string connectionString = "Data Source=.;Initial Catalog=test_db;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "Select * from Invoice_Hed";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read()){
                            string v = reader.GetString(1);
                            Console.WriteLine(v);
                        }
                    }
                }
            }
        }
    }

    
}
