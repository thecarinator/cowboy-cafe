using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the Rustler's ribs entree
    /// </summary>
    public class RustlersRibs
    {
        public double Price
        {
            get { return 7.50; }
        }

        public uint Calories
        {
            get { return 894; }
        }

        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                
                return instructions;
            }
        }
    }
}
