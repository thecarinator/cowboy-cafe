using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the Angry chicken
    /// </summary>
    public class AngryChicken
    {

        private bool bread = true;
        /// <summary>
        /// If there's bread with the chicken
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }

        private bool pickles = true;
        /// <summary>
        /// If the chicken has pickles
        /// </summary>
        public bool Pickle
        {
            get { return pickles; }
            set { pickles = value; }
        }

        /// <summary>
        /// The price for the chicken
        /// </summary>
        public double Price
        {
            get { return 5.99; }
        }

        /// <summary>
        /// The calories for the chicken
        /// </summary>
        public uint Calories
        {
            get { return 190; }
        }

        /// <summary>
        /// Special instruction for the chicken
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (!bread) instructions.Add("hold bread");
                if (!pickles) instructions.Add("hold pickle");
                return instructions;
            }
        }
    }
}
