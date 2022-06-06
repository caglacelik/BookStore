using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    /**
   * @brief   This file includes to cd information.
   */
    /// <summary>
    /// This function holds the music types.
    /// </summary>
    public enum MusicType { Rock, Pop, Arabesque, Metal, HipHop }

    public class MusicCD : Product
    {
        /// <summary>
        /// This function used to get and set operation.
        /// </summary
        public string Singer { get; set; }
        /// <summary>
        /// This function used to get and set operation.
        /// </summary
        public MusicType Type { get; set; }
        /// <summary>
        /// This function used to print product properties.
        /// </summary>
        public override void PrintProperties()
        {
            Console.WriteLine("{0} {1} {2} {3} {4}", this.Id, this.Name, this.UnitPrice, this.Singer, this.Type);

        }
    }
}