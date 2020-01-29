using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class DakotaDoubleBurger
    {
        private bool tomato = true;
        private bool lettuce = true;
        private bool mayo = true;
        private bool bun = true;
        public bool Bun
        {
            get { return bun; }
            set { bun = value; }
        }
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
            get { return 5.20; }
        }

        public uint Calories
        {
            get { return 464; }
        }

        public List<string> SpecialInstructions
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
