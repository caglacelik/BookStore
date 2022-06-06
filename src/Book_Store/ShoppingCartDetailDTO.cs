using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    /**   
    * @brief    This class includes detailed shopping cart items.
    */


    public class ShoppingCartDetailDTO
    {

        /// <summary>
        /// This function used to get and set operation for ProductName.
        /// </summary>
        ///<returns> The name of product. </returns>
        public string ProductName { get; set; }

        /// <summary>
        /// This function used to get and set operation for ProductPrice.
        /// </summary>
        ///<returns> The price of product. </returns>
        public double ProductPrice { get; set; }

        /// <summary>
        /// This function used to get and set operation for Quantity.
        /// </summary>
        ///<returns> The quantity of product. </returns>
        public int Quantity { get; set; }

        /// <summary>
        /// This function used to get and set operation for TotalPrice.
        /// </summary>
        ///<returns> The total price of the product. </returns>
        public double TotalPrice { get; set; }

        /// <summary>
        /// Constructor for ShoppingCartDetailDTO
        /// </summary>
        public ShoppingCartDetailDTO()
        {
        }

        /// <summary>
        /// Constructor for ShoppingCartDetailDTO when the parameters are given.
        /// </summary>
        /// <param name="productName">This parameter is a string that holds product name</param>
        /// <param name="productPrice">This parameter is a double value that holds product price</param>
        /// <param name="quantity">This parameter is an integer that is quantity</param>
        public ShoppingCartDetailDTO(string productName, double productPrice, int quantity)
        {
            ProductName = productName;
            ProductPrice = productPrice;
            Quantity = quantity;
            TotalPrice = productPrice * quantity;
        }
    }
}
