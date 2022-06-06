using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    /**
    * @brief   This file is Data Access Layer of magazines.
    */
    public class MagazineDal : IMagazineDal
    {
        string _connectionString = "Data Source=SQL5097.site4now.net;Initial Catalog=db_a750c4_burakosova;User Id=db_a750c4_burakosova_admin;Password=admin123";
        /// <summary>
        /// This function holds a list named magazine and returns the magazines.
        /// </summary>
        /// <returns>magazines</returns>
        public List<Magazine> GetAll()
        {
            List<Magazine> magazines = new List<Magazine>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM Products p JOIN Magazines m on p.Id = m.ProductId", connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Magazine magazine = new Magazine
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            Issue = reader["Issue"].ToString(),
                            Type = (MagazineType)Enum.Parse(typeof(MagazineType), reader["Type"].ToString()),
                            UnitPrice = Convert.ToDouble(reader["Price"])
                        };
                        magazines.Add(magazine);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return magazines;
        }
        /// This function arranges the magazine product according to its id in database.
        /// </summary>
        /// <param name="id">ID of product .</param>
        /// <param name="magazine">The object from magazine class.</param>
        /// <returns> This function does not return a value. </returns>
        public void getWithId(int id, Magazine magazine)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Products p JOIN Magazines b on p.Id = b.ProductId WHERE p.Id=@id", connection);
                command.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    magazine.Id = Convert.ToInt32(reader["Id"]);
                    magazine.Name = reader["Name"].ToString();
                    magazine.UnitPrice = Convert.ToDouble(reader["Price"]);
                    magazine.Issue = reader["Issue"].ToString();
                    magazine.Type = (MagazineType)Enum.Parse(typeof(MagazineType), reader["Type"].ToString());
                }
                reader.Close();
            }

        }
    }
}