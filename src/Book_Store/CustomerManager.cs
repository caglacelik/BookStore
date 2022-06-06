using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store
{
    /**
    * @brief   This class includes to Customer manager operations for logined customer information
    */
    class CustomerManager
    {
        private static CustomerManager _customerManager;
        static object _lockObject = new object();
        private Customer _customer;
        /// <summary>
        /// This function used to get and set operations for customer
        /// </summary>
        /// <returns> _customer </returns>
        /// 
        public Customer User { get => _customer; set => _customer = value; }
        /// <summary>
        /// This function is used to create new customer with singleton design
        /// </summary>
        /// <returns>_customerManager</returns>
        public static CustomerManager CreateAsSingleton()
        {
            lock (_lockObject)
            {
                if (_customerManager == null)
                {
                    _customerManager = new CustomerManager();

                }
            }
            return _customerManager;
        }

    }
}