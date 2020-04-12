/* Author: Cari Miller
 * Class: AngryChicken.cs
 * Purpose: Class for Angry Chicken
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the Angry chicken
    /// </summary>
    public class AngryChicken: Entree
    {
        private bool bread = true;
        /// <summary>
        /// If there's bread with the chicken
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set 
            {
                if (bread == value) return;
                bread = value;
                NotifyOfPropertyChange("Bread");
            }
        }

        private bool pickles = true;
        /// <summary>
        /// If the chicken has pickles
        /// </summary>
        public bool Pickle
        {
            get { return pickles; }
            set 
            {
                if (pickles == value) return;
                pickles = value;
                NotifyOfPropertyChange("Pickle");
            }
        }

        /// <summary>
        /// The price for the chicken
        /// </summary>
        public override double Price
        {
            get { return 5.99; }
        }

        /// <summary>
        /// The calories for the chicken
        /// </summary>
        public override uint Calories
        {
            get { return 190; }
        }

        /// <summary>
        /// Special instruction for the chicken
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
        /// gets angry chicken as string
        /// </summary>
        /// <returns> returns string </returns>
        public override string ToString()
        {
            return "Angry Chicken";
        }
    }
}
