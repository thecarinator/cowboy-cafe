using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the Dakota Double burger entree
    /// </summary>
    public class DakotaDoubleBurger: Entree
    {
        private bool bun = true;
        /// <summary>
        /// If the double burger has buns
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set { bun = value; }
        }

        private bool tomato = true;
        /// <summary>
        /// If the double burger has tomatoes
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value; }
        }

        private bool lettuce = true;
        /// <summary>
        /// If the double burger has lettuce 
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set { lettuce = value; }
        }

        private bool mayo = true;
        /// <summary>
        /// If the double burger has mayo
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set { mayo = value; }
        }

        private bool ketchup = true;
        /// <summary>
        /// If the double burger has ketchup
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value; }
        }

        private bool mustard = true;
        /// <summary>
        /// If the double burger has mustard
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value; }
        }

        private bool pickles = true;
        /// <summary>
        /// If the double burger has pickles
        /// </summary>
        public bool Pickle
        {
            get { return pickles; }
            set { pickles = value; }
        }

        private bool cheese = true;
        /// <summary>
        /// If the double burger has cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }

        /// <summary>
        /// The price for the double burger
        /// </summary>
        public override double Price
        {
            get { return 5.20; }
        }

        /// <summary>
        /// The calories for the double burger
        /// </summary>
        public override uint Calories
        {
            get { return 464; }
        }

        /// <summary>
        /// Special instructions for the double burger
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (!bun) instructions.Add("hold bun");
                if (!tomato) instructions.Add("hold tomato");
                if (!lettuce) instructions.Add("hold lettuce");
                if (!mayo) instructions.Add("hold mayo");
                if (!ketchup) instructions.Add("hold ketchup");
                if (!mustard) instructions.Add("hold mustard");
                if (!pickles) instructions.Add("hold pickle");
                if (!cheese) instructions.Add("hold cheese");
                return instructions;
            }
        }
    }
}
