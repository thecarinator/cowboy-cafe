using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class CowboyCoffee : Drink
    {
        public bool Decaf { get; set; }
        public bool RoomForCream { get; set; }
        public override bool Ice { get; set; }

        public override List<string> SpecialInstructions
        {
            get
            {
                var instr = new List<string>();
                if (Ice) instr.Add("Add Ice");
                if (RoomForCream) instr.Add("Room for Cream");
                return instr;
            }
        }

        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Large:
                        return 1.60;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 3;
                    case Size.Medium:
                        return 5;
                    case Size.Large:
                        return 7;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
    }
}
