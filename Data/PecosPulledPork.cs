/* Author: Cari Miller
 * Class: PecosPulledPork.cs
 * Purpose: class for Pecos Pulled Pork
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the Pecos Pulled Pork entree
    /// </summary>
    public class PecosPulledPork: Entree
    {
        private bool bread = true;
        /// <summary>
        /// If the pulled pork has bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }

        private bool pickles = true;
        /// <summary>
        /// If the pulled pork has pickles
        /// </summary>
        public bool Pickle
        {
            get { return pickles; }
            set { pickles = value; }
        }

        /// <summary>
        /// The price for the Pecos Pulled Pork
        /// </summary>
        public override double Price
        {
            get { return 5.88; }
        }

        /// <summary>
        /// The calories for the Pecos Pulled Pork
        /// </summary>
        public override uint Calories
        {
            get { return 528; }
        }

        /// <summary>
        /// Special instructions for the Pecos Pulled Pork
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (!bread) instructions.Add("hold bread");
                if (!pickles) instructions.Add("hold pickle");
                return instructions;
            }
        }

        /// <summary>
        /// gets pecos pulled pork as string
        /// </summary>
        /// <returns> returns string </returns>
        public override string ToString()
        {
            return "Pecos Pulled Pork";
        }
    }
}

