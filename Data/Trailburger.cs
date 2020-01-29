using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TrailBurger
    {
        private bool bun = true;
        public bool Bun
        {
            get { return bun; }
            set { bun = value; }
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

        public double Price
        {
            get { return 4.50; }
        }

        public uint Calories
        {
            get { return 288; }
        }

        public List<string> SpecialInstructions
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
    }
}

