﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the Rustler's ribs entree
    /// </summary>
    public class RustlersRibs: Entree
    {
        /// <summary>
        /// The price of the Rustler's ribs
        /// </summary>
        public override double Price
        {
            get { return 7.50; }
        }

        /// <summary>
        /// The calories of the Rustler's ribs
        /// </summary>
        public override uint Calories
        {
            get { return 894; }
        }

        /// <summary>
        /// Special instrctions for the preparation of the ribs
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                
                return instructions;
            }
        }
    }
}
