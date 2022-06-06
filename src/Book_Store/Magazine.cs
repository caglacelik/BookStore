using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    /**
   * @brief   This file includes to magazine information.
   */
    /// <summary>
    /// This function holds the magazine types.
    /// </summary>
    public enum MagazineType { Actual, Cars, Documentary, Fashion, Technology }

    public class Magazine : Product
    {
        /// <summary>
        /// This function used to get and set operation.
        /// </summary>
        public string Issue { get; set; }
        /// <summary>
        /// This function used to get and set operation.
        /// </summary>
        public MagazineType Type { get; set; }
        /// <summary>
        /// This function used to print product properties.
        /// </summary>
        public override void PrintProperties()
        {
            Console.WriteLine("{0} {1} {2} {3} {4}", this.Id, this.Name, this.UnitPrice, this.Issue, this.Type);
        }
    }
}