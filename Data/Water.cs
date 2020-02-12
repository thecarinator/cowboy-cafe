using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Water : Drink
    {
        private bool lemon = false;

        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; }
        }
        private bool ice = true;

        public override bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        public override List<string> SpecialInstructions
        {
            get { }
        }

        public override double Price => throw new NotImplementedException();

        public override uint Calories => throw new NotImplementedException();
    }
}
