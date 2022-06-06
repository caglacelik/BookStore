using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    /**   
    * @brief    This file includes book information.
    */
    public class Book : Product
    {
        /// <summary>
        /// This function used to get and set operation.
        /// </summary>
        public string ISBN { get; set; }
        /// <summary>
        /// This function used to get and set operation.
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// This function used to get and set operation.
        /// </summary>
        public string Publisher { get; set; }
        /// <summary>
        /// This function used to get and set operation.
        /// </summary>
        public int Page { get; set; }
        /// <summary>
        /// This function used to print product properties.
        /// </summary>

        public override void PrintProperties()
        {
            Console.WriteLine("{0} {1} {2} {3} {4} {5}", this.Id, this.Name, this.UnitPrice, this.Author, this.ISBN, this.Publisher, this.Page);
        }
    }
}