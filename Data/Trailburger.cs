using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Trailburger
    {
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

        public bool Pickles
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
                if (!ketchup) instructions.Add("hold ketchup");
                if (!mustard) instructions.Add("hold mustard");
                if (!pickles) instructions.Add("hold pickles");
                if (!cheese) instructions.Add("hold cheese");
                return instructions;
            }
        }
    }
}

