using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class AllProducts : IAllProducts
    {

        private List<Models.Product> _product;
        public List<Models.Product> _list;
        string connectionString = "Data Source=.;Initial Catalog=test_db;Integrated Security=True";

        public AllProducts()
        {
            _product = new List<Models.Product>();
            _list = new List<Models.Product>();
        }

        public JsonResult GetProduct()
        {
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

                            _list.Add(invoiceList);
                        }
                    }
                }
            }
            return new JsonResult(JsonConvert.DeserializeObject(JsonConvert.SerializeObject(_list)));
        }

        public JsonResult AddProduct(Product product)
        {
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
            return new JsonResult(product);
        }

        public JsonResult DeleteProduct(string id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var mycommand = new SqlCommand("DELETE FROM Product WHERE Products_id=@Products_id",
                               connection);

                mycommand.Parameters.AddWithValue("@Products_id", id);
                mycommand.ExecuteNonQuery();
            }
            return new JsonResult(id);
        }

        public JsonResult UpdateProduct(Product p)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var mycommand = new SqlCommand("UPDATE Product SET Product_name=@val2, Products_price=@val3," +
                    " Products_qty=@val4 WHERE Products_id=@Products_id",
                               connection);

                mycommand.Parameters.AddWithValue("@val1", p.Products_id);
                mycommand.Parameters.AddWithValue("@val2", p.Product_Name);
                mycommand.Parameters.AddWithValue("@val3", p.Products_qty);
                mycommand.Parameters.AddWithValue("@val4", p.Products_qty);
                mycommand.Parameters.AddWithValue("@Products_id", p.Products_id);
                mycommand.ExecuteNonQuery();
            }
            return new JsonResult(p);
        }
    }
}
