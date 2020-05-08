/* Author: Cari Miller
 * Class: PanDeCampo.cs
 * Purpose: Class for Pan de Campo
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Pan de Campo side
    /// </summary>
    public class PanDeCampo: Side
    {

        public PanDeCampo() { }
        public PanDeCampo(Size size) { Size = size; }
        /// <summary>
        /// the price of the pan de campo
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
        /// the calories of the pan de campo
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 227;
                    case Size.Medium:
                        return 269;
                    case Size.Large:
                        return 367;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Gets Pan de Campo as string
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
            return be + " Pan de Campo";
        }
    }

}
