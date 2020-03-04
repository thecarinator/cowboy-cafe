/* Author: Cari Miller
 * Class: Entree.cs
 * Purpose: Base class for entree
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing an entree
    /// </summary>
    public abstract class Entree:IOrderItem
    {
        /// <summary>
        /// gets the price of the entree
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// gets the calories of the  entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// gets the special instructions for the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
