/* Author: Cari Miller
 * Class: CowboyCoffee.cs
 * Purpose: Class for Cowboy coffee
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the cowboy coffee drink
    /// </summary>
    public class CowboyCoffee : Drink
    {
        private bool decaf = false;
        /// <summary>
        /// If the coffee is decaf
        /// </summary>
        public bool Decaf
        {
            get { return decaf; }
            set
            {
                if (decaf == value) return;
                decaf = value;
                NotifyOfPropertyChange("Decaf");
            }
        }


        private bool roc = false;
        /// <summary>
        /// If the coffee has room for cream
        /// </summary>
        public bool RoomForCream 
        {
            get { return roc; }
            set
            {
                if (roc == value) return;
                roc = value;
                NotifyOfPropertyChange("RoomForCream");
            }
        
        }


        private bool ice = false;
        /// <summary>
        /// If the coffee has ice
        /// </summary>
        public override bool Ice 
        {
            get { return ice; }
            set
            {
                if (ice == value) return;
                ice = value;
                NotifyOfPropertyChange("Ice");
            }
        }

        /// <summary>
        /// Special instructions for the coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instr = new List<string>();
                if (Ice) instr.Add("Add Ice");
                if (RoomForCream) instr.Add("Room for Cream");
                return instr;
            }
        }

        /// <summary>
        /// Price for the coffee
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Large:
                        return 1.60;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Calories of the coffee
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 3;
                    case Size.Medium:
                        return 5;
                    case Size.Large:
                        return 7;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        
        /// <summary>
        /// gets cowboy coffee as string
        /// </summary>
        /// <returns>returns string </returns>
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
            if (Decaf)
            {
                return be + " Decaf Cowboy Coffee";
            }
            else
            {
                return be + " Cowboy Coffee";
            }
        }
    }
}
