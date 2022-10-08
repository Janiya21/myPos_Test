﻿using Microsoft.AspNetCore.Mvc;
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

        public AllProducts()
        {
            _product = new List<Models.Product>();
            _list = new List<Models.Product>();
        }

        public JsonResult GetProduct()
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

                            _list.Add(invoiceList);
                        }
                    }
                }
            }
            return new JsonResult(JsonConvert.DeserializeObject(JsonConvert.SerializeObject(_list)));
        }

        public JsonResult AddProduct(Product product)
        {
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
            return new JsonResult(product);
        }

        public string DeleteProduct(string id)
        {
            throw new System.NotImplementedException();
        }

        public Product UpdateProduct(string id, Product customer)
        {
            throw new System.NotImplementedException();
        }
    }
}
