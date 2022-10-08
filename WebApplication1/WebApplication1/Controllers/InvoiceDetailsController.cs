using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data.SqlClient;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/details")]
    [ApiController]
    public class InvoiceDetailsController : ControllerBase
    {
        public List<Models.Invoice_Details> list = new List<Models.Invoice_Details>();

        [HttpGet("getAll")]
        public JsonResult OnGet()
        {
            string connectionString = "Data Source=.;Initial Catalog=test_db;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "Select * from Invoice_Details";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Invoice_Details detailsList = new Invoice_Details();
                            detailsList.Invoice_Details_Id = reader.GetInt32(0);
                            detailsList.Invoice_Details_qty = reader.GetInt32(0);
                            detailsList.Invoice_Details_amount = reader.GetDecimal(2);
                            detailsList.Invoice_Hed_Invoice_Hed_Id = reader.GetInt32(0);
                            detailsList.Products_Product_id = reader.GetInt32(0);

                            list.Add(detailsList);
                        }
                    }
                }
            }
            return new JsonResult(JsonConvert.DeserializeObject(JsonConvert.SerializeObject(list)));
        }
    }
}
