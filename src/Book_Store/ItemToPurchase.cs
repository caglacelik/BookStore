using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    /**   
     * @brief    This class includes ItemToPurchase informations 
     */
    public class ItemToPurchase
    {
        /// <summary>
        /// This function used to get and set operations for Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// This function used to get and set operations for product
        /// </summary>
        public Product Product { get; set; }
        /// <summary>
        /// This function used to get and set operations for quantity
        /// </summary>
        public int Quantity { get; set; }
    }
}