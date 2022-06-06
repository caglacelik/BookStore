using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public enum PaymentType { CreditCard, DebitCard, Cash }
    /**
    * @brief   This class includes order informations
    */
    public class Order
    {
        /// <summary>
        /// This function used to get and set operation for order Id
        /// </summary>
        /// 
        public int Id { get; set; }
        /// <summary>
        /// This function used to get and set operation for payment type
        /// </summary>
        /// 
        public PaymentType paymentType { get; set; }
        /// <summary>
        /// This function used to get and set operation for date
        /// </summary>
        /// 
        public DateTime Date { get; set; }
        /// <summary>
        /// This function used to get and set operation for order's total price
        /// </summary>
        /// 
        public double TotalPrice { get; set; }
        /// <summary>
        /// This function used to get and set operation for order's customer Id 
        /// </summary>
        /// 
        public int CustomerId { get; set; }

    }
}