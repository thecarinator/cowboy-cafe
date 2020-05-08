/* Author: Cari Miller
 * Class: CornDodgers
 * Purpose: Class for the corn dodgers
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the corn dodgers side
    /// </summary>
    public class CornDodgers: Side
    {
        /// <summary>
        /// Default Corn Dodgers
        /// </summary>
        public CornDodgers() { }
        /// <summary>
        /// Not default corn dodgers
        /// </summary>
        /// <param name="size"></param>
        public CornDodgers(Size size) { Size = size; }
        /// <summary>
        /// Price of the corn dodgers
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
        /// calories of the corn dodgers
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 512;
                    case Size.Medium:
                        return 685;
                    case Size.Large:
                        return 717;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// gets corn dodgers as string
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
            return be + " Corn Dodgers";
        }
    }
}
