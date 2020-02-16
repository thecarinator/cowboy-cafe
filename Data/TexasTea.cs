using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTea : Drink
    {
        private bool sweet = true;
        public bool Sweet
        {
            get { return sweet; }
            set { sweet = value; }
        }
        public bool Lemon { get; set; }
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
                if (Lemon) instr.Add("Add Lemon");
                if (!ice) instr.Add("Hold Ice");
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
                        return 1.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Large:
                        return 2.00;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        public override uint Calories
        {
            get
            {
                if (Sweet)
                {
                    switch (Size)
                    {
                        case Size.Small:
                            return 10;
                        case Size.Medium:
                            return 22;
                        case Size.Large:
                            return 36;
                        default:
                            throw new NotImplementedException();
                    }
                }
                else
                {
                    switch (Size)
                    {
                        case Size.Small:
                            return 5;
                        case Size.Medium:
                            return 11;
                        case Size.Large:
                            return 18;
                        default:
                            throw new NotImplementedException();
                    }
                }
            }
        }
    }
}
