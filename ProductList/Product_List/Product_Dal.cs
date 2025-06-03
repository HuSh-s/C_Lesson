using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_List
{
    public class Product_Dal
    {
        SqlConnection connection = new SqlConnection(@"server = (localdb)\mssqllocaldb; initial catalog = Products; integrated security = true"); //database baglantı
        public List<Products> Print()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand command = new SqlCommand("Select *from Products", connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Products> products = new List<Products>();

            while (reader.Read()) 
            {
                Products product = new Products
                {
                    Id = Convert.ToInt32(reader["ID"]),
                    Name = Convert.ToString(reader["Name"]),
                    Stock = Convert.ToInt32(reader["Stock"]),
                    Price = Convert.ToInt32(reader["Price"]),
                };

                products.Add(product);
            }

            reader.Close();
            connection.Close();
            return products;
        }

        public void Add(Products product)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("Insert into Products values(@Name,@Price,@Stock)", connection);
            command.Parameters.AddWithValue("Name", product.Name);
            command.Parameters.AddWithValue("Price", product.Price);
            command.Parameters.AddWithValue("Stock", product.Stock);
            command.ExecuteNonQuery(); //gerçekten böyle bir veri var mı yok mu

            connection.Close();
        }

        public void Update(Products product)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("Update Products set Name=@Name, Price=@Price, Stock=@Stock where Id=@Id", connection);
            command.Parameters.AddWithValue("Name", product.Name);
            command.Parameters.AddWithValue("Price", product.Price);
            command.Parameters.AddWithValue("Stock", product.Stock);
            command.Parameters.AddWithValue("Id", product.Id);
            command.ExecuteNonQuery(); //gerçekten böyle bir veri var mı yok mu

            connection.Close();
        }

        public void Delete(Products product)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("Delete from Products where Id=@Id", connection);
            command.Parameters.AddWithValue("Id", product.Id);
            command.ExecuteNonQuery();
            connection.Close();
        }


    }
}
