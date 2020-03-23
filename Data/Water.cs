﻿/* Author: Cari Miller
 * Class: Water.cs
 * Purpose: Class for water
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing water
    /// </summary>
    public class Water : Drink
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private bool lemon = false;
        /// <summary>
        /// If the water has lemon
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set { 
                lemon = value;
                NotifyOfPropertyChange("Lemon");
            }
        }

        private bool ice = true;
        /// <summary>
        /// If the water has ice
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set { ice = value;
                NotifyOfPropertyChange("Ice");
            }
        }

        /// <summary>
        /// Special instructions for water
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instr = new List<string>();
                if (!ice) instr.Add("Hold Ice");
                if (lemon) instr.Add("Add Lemon");
                return instr;
            }
        }

        /// <summary>
        /// Price for water
        /// </summary>
        public override double Price { get { return 0.12; } }

        /// <summary>
        /// Calories of water
        /// </summary>
        public override uint Calories { get { return 0; } }

        /// <summary>
        /// gets water as string
        /// </summary>
        /// <returns>returns string</returns>
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
            return be + " Water";
        }
    }
}
