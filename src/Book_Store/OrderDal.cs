using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DataAccess.Concrete
{
    /**
    * @brief   This file is Data Access Layer of Order.
    */
    public class OrderDal : IOrderDal
    {
        string _connectionString = "Data Source=SQL5097.site4now.net;Initial Catalog=db_a750c4_burakosova;User Id=db_a750c4_burakosova_admin;Password=admin123";

        /// <summary>
        /// This function adds the order to the database.
        /// </summary>
        /// <param name="order">The object of order.</param>
        /// <returns>This function does not return a value</returns>
        public void AddOrder(Order order)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("Insert into Orders (PaymentType,Date,TotalPrice,CustomerId) values(@payment,@date,@price,@customer)", connection);
                    command.Parameters.AddWithValue("@payment", order.paymentType.ToString());
                    command.Parameters.AddWithValue("@date", order.Date);
                    command.Parameters.AddWithValue("@price", order.TotalPrice);
                    command.Parameters.AddWithValue("@customer", order.CustomerId);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        /// <summary>
        /// This function deletes the order from the database.
        /// </summary>
        /// <param name="order">The object of order.</param>
        /// <returns>This function does not return a value</returns>
        public void DeleteOrder(int orderId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM Orders WHERE Id = @id", connection);
                    command.Parameters.AddWithValue("@id", orderId);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        /// <summary>
        /// This function returns the list of Order objects.
        /// </summary>
        /// <param name="order">The object of order.</param>
        /// <returns>List of Orders</returns>
        public List<Order> GetOrders(int customerId)
        {
            List<Order> orders = new List<Order>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                SqlCommand command = new SqlCommand("SELECT * FROM Orders WHERE CustomerId=@id", connection);
                command.Parameters.AddWithValue("@id", customerId);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Order order = new Order
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Date = (DateTime)reader["Date"],
                            paymentType = (PaymentType)Enum.Parse(typeof(PaymentType), reader["PaymentType"].ToString()),
                            TotalPrice = Convert.ToDouble(reader["TotalPrice"]),
                        };
                        orders.Add(order);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return orders;

        }
    }
}
