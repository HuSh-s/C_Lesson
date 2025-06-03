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
        public List<Products> Print()
        {
            SqlConnection connection = new SqlConnection(@"server = (localdb)\mssqllocaldb; initial catalog = Products; integrated security = true");
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


    }
}
