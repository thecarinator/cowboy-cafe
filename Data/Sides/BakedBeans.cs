/* Author: Cari Miller
 * Class: BakedBeans.cs
 * Purpose: Class for baked beans
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the baked beans side
    /// </summary>
    public class BakedBeans: Side
    {
        /// <summary>
        /// Default baked beans
        /// </summary>
        public BakedBeans() { }

        /// <summary>
        /// Not default baked beans
        /// </summary>
        /// <param name="size">what size they are</param>
        public BakedBeans(Size size) { Size = size; }
        /// <summary>
        /// Price of the baked beans
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.59;
                    case Size.Medium:
                        return 1.79;
                    case Size.Large:
                        return 1.99;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        
        /// <summary>
        /// Calories of the baked beans
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 312;
                    case Size.Medium:
                        return 378;
                    case Size.Large:
                        return 410;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// gets baked beans as string
        /// </summary>
        /// <returns> returns string </returns>
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
            return be + " Baked Beans";
        }
    }
}
