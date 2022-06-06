using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataAccess.Concrete
{
    /**
    * @brief   This file is Data Access Layer of shopping cart.
    */

    
    public class ShoppingCartDal : IShoppingCartDal
    {
        private string _connectionString = "Data Source=SQL5097.site4now.net;Initial Catalog=db_a750c4_burakosova;User Id=db_a750c4_burakosova_admin;Password=admin123";

        /// <summary>
        /// This function returns the detailed shopping cart and every item in it from the database.
        /// </summary>
        /// <param name="customerId">The customerId is the Id of the logged customer.</param>
        /// <returns>ShoppingCartDetailDTO</returns>
        public List<ShoppingCartDetailDTO> GetByCustomerId(int customerId)
        {
            List<ShoppingCartDetailDTO> cartDetails = new List<ShoppingCartDetailDTO>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM ShoppingCarts sc JOIN ItemsToPurchase it on sc.ItemToPurchase = it.Id JOIN Products p on p.Id = it.Product where sc.CustomerId = @id", connection);
                command.Parameters.AddWithValue("@id", customerId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ShoppingCartDetailDTO cartDetail = new ShoppingCartDetailDTO(
                                reader["Name"].ToString(),
                                Convert.ToDouble(reader["Price"]),
                                Convert.ToInt32(reader["Quantity"])
                            );
                        cartDetails.Add(cartDetail);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return cartDetails;
        }

        /// <summary>
        /// This function adds the product to the database.
        /// </summary>
        /// <param name="customerId">The customerId is the Id of the logged customer.</param>
        /// <param name="item">The ItemPurchase object that will be added to shopping cart.</param>
        /// <returns>This function does not return a value</returns>
        public void AddProduct(ItemToPurchase item, int customerId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    // Add to ItemsToPurchase Table 
                    SqlCommand command = new SqlCommand("INSERT INTO ItemsToPurchase VALUES(@productId,@quantity); SELECT SCOPE_IDENTITY();", connection);
                    command.Parameters.AddWithValue("@productId", item.Product.Id);
                    command.Parameters.AddWithValue("@quantity", item.Quantity);
                    int newId = Convert.ToInt32(command.ExecuteScalar());
                    //command.ExecuteNonQuery();

                    // Add to ShoppingCarts Table
                    command = new SqlCommand("INSERT INTO ShoppingCarts (CustomerId,ItemToPurchase) VALUES(@customerId,@itemToPurchase)", connection);
                    command.Parameters.AddWithValue("@customerId", customerId);
                    command.Parameters.AddWithValue("@itemToPurchase", newId);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        /// <summary>
        /// This function removes the product from the database regardless how many of it .
        /// </summary>
        /// <param name="item">The ItemPurchase object that will be removed from the shopping cart.</param>
        /// <returns>This function does not return a value</returns>
        public void RemoveProduct(ItemToPurchase item)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    // Remove from ItemsToPurchase Table it cascades and also deletes form ShoppingCarts Table
                    SqlCommand command = new SqlCommand("DELETE FROM ItemsToPurchase WHERE Id=@id", connection);
                    command.Parameters.AddWithValue("@id", item.Id);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        /// <summary>
        /// This function clears the shopping cart.
        /// Deletes every item in the cart from the database
        /// </summary>
        /// <param name="customerId">The customerId is the Id of the logged customer.</param>
        /// <returns>This function does not return a value</returns>
        public void ClearCart(int customerId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    // Delete from ShoppingCarts table
                    SqlCommand command = new SqlCommand("DELETE FROM ShoppingCarts WHERE CustomerId=@id", connection);
                    command.Parameters.AddWithValue("@id", customerId);
                    command.ExecuteNonQuery();

                    // Delete from ItemsToPurchase table
                    command = new SqlCommand("DELETE FROM ItemsToPurchase WHERE Id not IN ( SELECT ItemToPurchase FROM ShoppingCarts WHERE ItemToPurchase is not null)", connection);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        /// <summary>
        /// This function gets the ItemsToPurchase objects as a list.
        /// The list is creates using database.
        /// </summary>
        /// <param name="customerId">The customerId is the Id of the logged customer.</param>
        /// <returns>List of ItemToPurchase objects. </returns>
        public List<ItemToPurchase> GetItemsToPurchase(int customerId)
        {
            List<ItemToPurchase> items = new List<ItemToPurchase>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT it.*,p.* FROM ShoppingCarts sc JOIN ItemsToPurchase it on sc.ItemToPurchase = it.Id JOIN Products p on p.Id = it.Product where sc.CustomerId = @id", connection);
                command.Parameters.AddWithValue("@id", customerId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ItemToPurchase item = new ItemToPurchase
                        {
                            Id = Convert.ToInt32(reader[0]),
                            Product = new Magazine { Id = Convert.ToInt32(reader[3]), Name = reader[4].ToString(), UnitPrice = Convert.ToInt32(reader[5]) },
                            Quantity = Convert.ToInt32(reader[2])
                        };
                        items.Add(item);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return items;
        }

        /// <summary>
        /// This function updates the itemtopurchase as its quantity.
        /// Updates the items in the database
        /// </summary>
        /// <param name="item">The ItemPurchase object that will be removed from the shopping cart.</param>
        /// <returns> This function does not return a value. </returns>
        public void UpdateItemToPurchase(ItemToPurchase item)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand("UPDATE ItemsToPurchase SET Quantity = @quantity WHERE Id=@id", connection);
                    command.Parameters.AddWithValue("@quantity", item.Quantity);
                    command.Parameters.AddWithValue("@id", item.Id);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
