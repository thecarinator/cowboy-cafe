/* Author: Cari Miller
 * Class: TexasTea.cs
 * Purpose: Class for Texas Tea
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the drink Texas Tea
    /// </summary>
    public class TexasTea : Drink
    {
        private bool sweet = true;
        /// <summary>
        /// Default Texas tea
        /// </summary>
        public TexasTea() { }
        /// <summary>
        /// Not default texas tea
        /// </summary>
        /// <param name="size">What size it is</param>
        /// <param name="s">Whether or not it is sweet</param>
        public TexasTea(Size size, bool s)
        {
            Size = size;
            sweet = s;
        }
        /// <summary>
        /// If the tea is sweet
        /// </summary>
        public bool Sweet
        {
            get { return sweet; }
            set 
            {
                if (sweet == value) return;
                sweet = value;
                NotifyOfPropertyChange("Sweet");
            }
        }


        private bool lemon = false;
        /// <summary>
        /// If the tea has lemon
        /// </summary>
        public bool Lemon 
        {
            get { return lemon; }
            set
            {
                if (lemon == value) return;
                lemon = value;
                NotifyOfPropertyChange("Lemon");
            }
        }

        
        private bool ice = true;
        /// <summary>
        /// If the tea has ice
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set 
            {
                if (ice == value) return;
                ice = value;
                NotifyOfPropertyChange("Ice");
            }
        }

        /// <summary>
        /// Special instructions for the tea
        /// </summary>
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

        /// <summary>
        /// Price for the tea
        /// </summary>
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

        /// <summary>
        /// Calories of the tea
        /// </summary>
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

        /// <summary>
        /// gets Texas tea as string
        /// </summary>
        /// <returns> returns string </returns>
        public override string ToString()
        {
            string be = "";
            string b = "";
            if (Size == Size.Small)
            {
                be = "Small";
            }
            else if (Size == Size.Medium)
            {
                be = "Medium";
            }
            else
            {
                be = "Large";
            }
            if (Sweet)
            {
                b = "Sweet";
            }
            else
            {
                b = "Plain";
            }
            return be + " Texas " + b + " Tea";
        }
    }
}
