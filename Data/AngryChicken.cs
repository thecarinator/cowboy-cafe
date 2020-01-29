using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class AngryChicken
    {
        private bool bread = true;

        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }

        private bool pickles = true;

        public bool Pickles
        {
            get { return pickles; }
            set { pickles = value; }
        }
        public double Price
        {
            get { return 5.99; }
        }

        public uint Calories
        {
            get { return 190; }
        }

        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (!bread) instructions.Add("hold bread");
                if (!pickles) instructions.Add("hold pickles");
                return instructions;
            }
        }
    }
}
