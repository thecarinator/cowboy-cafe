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
            get
            {
                var instr = new List<string>();
                if (!ice) instr.Add("Hold Ice");
                if (lemon) instr.Add("Add Lemon");
                return instr;
            }
        }

        public override double Price { get { return 0.12; } }

        public override uint Calories { get { return 0; } }
    }
}
