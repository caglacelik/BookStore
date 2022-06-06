using System;

namespace Entities.Abstract
{
    /**
  * @brief   This is an abstract class named Product.
  */
    public abstract class Product
    {
        /// <summary>
        /// This function used to get and set operation.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// This function used to get and set operation.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// This function used to get and set operation.
        /// </summary>
        public double UnitPrice { get; set; }
        /// <summary>
        /// This function used to print product properties.
        /// </summary>
        public abstract void PrintProperties();
    }
}