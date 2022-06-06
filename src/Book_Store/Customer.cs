using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store
{
    /**
   * @brief   This class includes customer informations and their operations
   */
    public class Customer
    {
        /// <summary>
        /// This function used to get and set operation for customer name
        /// </summary>
        /// <returns> customerName </returns>
        /// 
        public string customerName { get; set; }
        /// <summary>
        /// This function used to get and set operation for customer ID
        /// </summary>
        /// <returns> customerID </returns>
        /// 
        public int customerID { get; set; }
        /// <summary>
        /// This function used to get and set operation for customer address
        /// </summary>
        /// <returns> customerAddress </returns>
        /// 
        public string customerAddress { get; set; }
        /// <summary>
        /// This function used to get and set operation customer email
        /// </summary>
        /// <returns> customerEmail </returns>
        /// 
        public string customerEmail { get; set; }
        /// <summary>
        /// This function used to get and set operation for customer username
        /// </summary>
        /// <returns> customerUsername </returns>
        ///
        public string customerUsername { get; set; }
        /// <summary>
        /// This function used to get and set operation for customer password
        /// </summary>
        /// <returns> customerPassword </returns>
        /// 
        public string customerPassword { get; set; }
        /// <summary>
        /// This function used to print customer information
        /// </summary>
        /// <returns> This function does not return a value </returns>
        /// 
        public void printCustomerDetails()
        {
            Console.WriteLine("Customer Name: " + customerName);
            Console.WriteLine("Customer ID : " + customerID);
            Console.WriteLine("Customer Address : " + customerAddress);
            Console.WriteLine("Customer Email : " + customerEmail);
            Console.WriteLine("Customer Username : " + customerUsername);
            Console.WriteLine("Customer Password : " + customerPassword);
        }

    }
}