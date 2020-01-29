using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTripleBurger
    {
        private bool bacon = true;
        private bool egg = true;
        private bool bun = true;
        public bool Bun
        {
            get { return bun; }
            set { bun = value; }
        }
        public bool Bacon
        {
            get { return bacon; }
            set { bacon = value; }
        }

        public bool Egg
        {
            get { return egg; }
            set { egg = value; }
        }
        private bool ketchup = true;

        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value; }
        }
        private bool mustard = true;

        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value; }


        }
        private bool pickles = true;
        public bool Pickle
        {
            get { return pickles; }
            set { pickles = value; }
        }
        private bool cheese = true;

        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }
        private bool tomato = true;
        private bool lettuce = true;
        private bool mayo = true;
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value; }
        }
        public bool Lettuce
        {
            get { return lettuce; }
            set { lettuce = value; }
        }
        public bool Mayo
        {
            get { return mayo; }
            set { mayo = value; }
        }
        public double Price
        {
            get { return 6.45; }
        }

        public uint Calories
        {
            get { return 698; }
        }

        public List<string> SpecialInstructions
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
    }
}
