using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataAccess.Concrete
{
    /**
    * @brief   This file is Data Access Layer of books.
    */
    public class BookDal : IBookDal
    {
        string _connectionString = "Data Source=SQL5097.site4now.net;Initial Catalog=db_a750c4_burakosova;User Id=db_a750c4_burakosova_admin;Password=admin123";
        /// <summary>
        /// This function holds a list named book and returns the books.
        /// </summary>
        /// <returns>List of books</returns>
        public List<Book> GetAll()
        {
            List<Book> books = new List<Book>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Products p JOIN Books b on p.Id = b.ProductId", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Book book = new Book
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                        UnitPrice = Convert.ToDouble(reader["Price"]),
                        Author = reader["Author"].ToString(),
                        Publisher = reader["Publisher"].ToString(),
                        ISBN = reader["ISBN"].ToString(),
                        Page = Convert.ToInt32(reader["Page"])
                    };
                    books.Add(book);
                }
                reader.Close();
            }

            return books;
        }
        /// <summary>
        /// This function arranges the book product according to its id in database.
        /// </summary>
        /// <param name="id">ID of product .</param>
        /// <param name="book">The object from book class.</param>
        /// <returns> This function does not return a value. </returns>
        public void getWithId(int id, Book book)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Products p JOIN Books b on p.Id = b.ProductId WHERE p.Id=@id", connection);
                command.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    book.Id = Convert.ToInt32(reader["Id"]);
                    book.Name = reader["Name"].ToString();
                    book.UnitPrice = Convert.ToDouble(reader["Price"]);
                    book.Author = reader["Author"].ToString();
                    book.Publisher = reader["Publisher"].ToString();
                    book.ISBN = reader["ISBN"].ToString();
                    book.Page = Convert.ToInt32(reader["Page"]);

                }
                reader.Close();
            }

        }
    }
}