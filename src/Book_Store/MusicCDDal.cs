using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Book_Store;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    /**
    * @brief   This file is Data Access Layer of books.
    */
    public class MusicCDDal : IMusicCDDal
    {
        string _connectionString = "Data Source=SQL5097.site4now.net;Initial Catalog=db_a750c4_burakosova;User Id=db_a750c4_burakosova_admin;Password=admin123";

        /// <summary>
        /// This function holds a list named for musicCDs and returns them.
        /// </summary>
        /// <returns>List of musicCDs</returns>
        public List<MusicCD> GetAll()
        {
            List<MusicCD> musicCDs = new List<MusicCD>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM Products p JOIN MusicCDs m on p.Id = m.ProductId", connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        MusicCD music = new MusicCD
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            UnitPrice = Convert.ToDouble(reader["Price"]),
                            Singer = reader["Singer"].ToString(),
                            Type = (MusicType)Enum.Parse(typeof(MusicType), reader["Type"].ToString())
                        };
                        musicCDs.Add(music);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return musicCDs;
        }

        /// <summary>
        /// This function arranges the musicCD product according to its id in database.
        /// </summary>
        /// <param name="id">ID of product .</param>
        /// <param name="book">The object from CD class.</param>
        /// <returns> This function does not return a value. </returns>
        public void getWithId(int id, MusicCD musicCD)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Products p JOIN MusicCDs b on p.Id = b.ProductId WHERE p.Id=@id", connection);
                command.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    musicCD.Id = Convert.ToInt32(reader["Id"]);
                    musicCD.Name = reader["Name"].ToString();
                    musicCD.UnitPrice = Convert.ToDouble(reader["Price"]);
                    musicCD.Singer = reader["Singer"].ToString();
                    musicCD.Type = (MusicType)Enum.Parse(typeof(MusicType), reader["Type"].ToString());

                }
                reader.Close();
            }

        }
    }
}
