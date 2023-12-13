using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Warenkorb_Yves
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return Name; // Hier kannst du den Text anpassen, der in der ComboBox angezeigt wird
        }
    }

    internal class DataAccess
    {
        private string connectionString = "Server=mssql1.webland.ch;Database=d041e_blj;User Id=d041e_blj;Password=BljDbPw_01;";

        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM products", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product p = new Product
                            {
                                Id = Convert.ToInt32(reader["product_id"]),
                                Name = reader["product_name"].ToString(),
                                Price = Convert.ToDouble(reader["product_price"])
                            };

                            products.Add(p);
                        }
                    }
                }
            }

            return products;
        }
    }
}