/* Author: Cari Miller
 * Class: JerkedSoda.cs
 * Purpose: Class for Jerked Soda
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the drink jerked soda
    /// </summary>
    public class JerkedSoda : Drink
    {
        /// <summary>
        /// Flavor of soda
        /// </summary>
        public SodaFlavor Flavor { get; set; }

        private bool ice = true;
        /// <summary>
        /// If the soda has ice
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        /// <summary>
        /// Special instructions for the soda
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instr = new List<string>();
                if (!ice) instr.Add("Hold Ice");
                return instr;
            }
        }

        /// <summary>
        /// Price for the soda
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
                        return 2.10;
                    case Size.Large:
                        return 2.59;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Calories of the soda
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 110;
                    case Size.Medium:
                        return 146;
                    case Size.Large:
                        return 198;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
    }
}
