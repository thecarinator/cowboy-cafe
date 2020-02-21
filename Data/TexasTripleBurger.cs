/* Author: Cari Miller
 * Class: TexasTripleBurger.cs
 * Purpose: Class for Texas Triple Burger
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the Texas triple burger entree
    /// </summary>
    public class TexasTripleBurger: Entree
    {
        private bool bun = true;
        /// <summary>
        /// If the triple burger has a bun
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set { bun = value; }
        }

        private bool bacon = true;
        /// <summary>
        /// If the triple burger has bacon
        /// </summary>
        public bool Bacon
        {
            get { return bacon; }
            set { bacon = value; }
        }
        private bool egg = true;
        /// <summary>
        /// If the triple burger has egg
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set { egg = value; }
        }

        private bool ketchup = true;
        /// <summary>
        /// If the triple burger has ketchup
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value; }
        }

        private bool mustard = true;
        /// <summary>
        /// If the triple burger has mustard
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value; }


        }

        private bool pickles = true;
        /// <summary>
        /// If the triple burger has pickles
        /// </summary>
        public bool Pickle
        {
            get { return pickles; }
            set { pickles = value; }
        }

        private bool cheese = true;
        /// <summary>
        /// If the triple burger has cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }

        private bool tomato = true;
        /// <summary>
        /// If the triple burger has tomatos
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value; }
        }

        private bool lettuce = true;
        /// <summary>
        /// If the triple burger has lettuce
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set { lettuce = value; }
        }

        private bool mayo = true;
        /// <summary>
        /// If the triple burger has mayo
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set { mayo = value; }
        }

        /// <summary>
        /// Price of the triple burger
        /// </summary>
        public override double Price
        {
            get { return 6.45; }
        }

        /// <summary>
        /// The calories of triple burger
        /// </summary>
        public override uint Calories
        {
            get { return 698; }
        }

        /// <summary>
        /// Special instructions for the triple burger
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (!bacon) instructions.Add("hold bacon");
                if (!bun) instructions.Add("hold bun");
                if (!egg) instructions.Add("hold egg");
                if (!ketchup) instructions.Add("hold ketchup");
                if (!mustard) instructions.Add("hold mustard");
                if (!pickles) instructions.Add("hold pickle");
                if (!cheese) instructions.Add("hold cheese");
                if (!tomato) instructions.Add("hold tomato");
                if (!lettuce) instructions.Add("hold lettuce");
                if (!mayo) instructions.Add("hold mayo");
                return instructions;
            }
        }

        /// <summary>
        /// gets Texas triple burger as string
        /// </summary>
        /// <returns> returns string</returns>
        public override string ToString()
        {
            return "Texas Triple Burger";
        }
    }
}
