﻿/* Author: Cari Miller
 * Class: Trailburger.cs
 * Purpose: Class for Trailburger
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the TrailBurger entree
    /// </summary>
    public class TrailBurger: Entree
    {
        private bool bun = true;
        /// <summary>
        /// If the burger has buns
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set { bun = value; }
        }

        private bool ketchup = true;
        /// <summary>
        /// If the burger has ketchup
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value; }
        }

        private bool mustard = true;
        /// <summary>
        /// If the burger has mustard
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value; }
        }

        private bool pickles = true;
        /// <summary>
        /// If the burger has pickles
        /// </summary>
        public bool Pickle
        {
            get { return pickles; }
            set { pickles = value; }
        }

        private bool cheese = true;
        /// <summary>
        /// If the burger has cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }

        /// <summary>
        /// The price of the burger
        /// </summary>
        public override double Price
        {
            get { return 4.50; }
        }

        /// <summary>
        /// The calories of the burger
        /// </summary>
        public override uint Calories
        {
            get { return 288; }
        }

        /// <summary>
        /// Special instructions for the burger
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (!bun) instructions.Add("hold bun");
                if (!ketchup) instructions.Add("hold ketchup");
                if (!mustard) instructions.Add("hold mustard");
                if (!pickles) instructions.Add("hold pickle");
                if (!cheese) instructions.Add("hold cheese");
                return instructions;
            }
        }

        /// <summary>
        /// Gets Trail burger as string
        /// </summary>
        /// <returns> return string </returns>
        public override string ToString()
        {
            return "Trail Burger";
        }
    }
}

