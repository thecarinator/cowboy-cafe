/* Author: Cari Miller
 * Class: ChiliCheeseFries.cs
 * Purpose: Class for Chili cheese fries
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the chili cheese fries side
    /// </summary>
    public class ChiliCheeseFries : Side
    {
        /// <summary>
        /// Price of the chili cheese fries
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.99;
                    case Size.Medium:
                        return 2.99;
                    case Size.Large:
                        return 3.99;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Calories of the chili cheese fries
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 433;
                    case Size.Medium:
                        return 524;
                    case Size.Large:
                        return 610;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        public override string ToString()
        {
            string be = "";
            if (Size == Size.Small)
            {
                be = "Small";
            }
            else if (Size == Size.Medium)
            {
                be = "Medium";
            }
            else
            {
                be = "Large";
            }
            return be + " Chili Cheese Fries";
        }
    }
}
