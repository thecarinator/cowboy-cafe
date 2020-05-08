/* Author: Cari Miller
 * Class: IOrderItem.cs
 * Purpose: Interface of order items
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// An interface representing a single item in order
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// The item name of this order item
        /// </summary>
        public string ItemName { get; }
        /// <summary>
        /// The price of this order item
        /// </summary>
        public double Price { get; }

        /// <summary>
        /// The calories of this order item
        /// </summary>
        public uint Calories { get; }
        /// <summary>
        /// The special instructions for this order item
        /// </summary>
        public List<string> SpecialInstructions { get; }
    }
}
