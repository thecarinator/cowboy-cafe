﻿/* Author: 
 * Edited by: Cari Miller
 * Class: CowpokeChili.cs
 * Purpose: Class for Cowpoke chili
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Cowpoke Chili entree
    /// </summary>
    public class CowpokeChili : Entree
    {
        private bool cheese = true;
        /// <summary>
        /// If the chili is topped with cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set
            {
                if (cheese == value) return;
                cheese = value;
                NotifyOfPropertyChange("Cheese");
            }
        }

        private bool sourCream = true;
        /// <summary>
        /// If the chili is topped with sour cream
        /// </summary>
        public bool SourCream
        {
            get { return sourCream; }
            set
            {
                if (sourCream == value) return;
                sourCream = value;
                NotifyOfPropertyChange("SourCream");
            }
        }

        private bool greenOnions = true;
        /// <summary>
        /// If the chili is topped with green onions
        /// </summary>
        public bool GreenOnions
        {
            get { return greenOnions; }
            set
            {
                if (greenOnions == value) return;
                greenOnions = value;
                NotifyOfPropertyChange("GreenOnions");
            }
        }

        private bool tortillaStrips = true;
        /// <summary>
        /// If the chili is topped with tortilla strips
        /// </summary>
        public bool TortillaStrips
        {
            get { return tortillaStrips; }
            set
            {
                if (tortillaStrips == value) return;
                tortillaStrips = value;
                NotifyOfPropertyChange("TortillaStrips");
            }
        }

        /// <summary>
        /// The price of the chili
        /// </summary>
        public override double Price
        {
            get
            {
                return 6.10;
            }
        }

        /// <summary>
        /// The calories of the chili
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 171;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the chili
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!cheese) instructions.Add("hold cheese");
                if (!sourCream) instructions.Add("hold sour cream");
                if (!greenOnions) instructions.Add("hold green onions");
                if (!tortillaStrips) instructions.Add("hold tortilla strips");

                return instructions;
            }
        }

        /// <summary>
        /// gets cowpoke chili as string
        /// </summary>
        /// <returns> returns string </returns>
        public override string ToString()
        {
            return "Cowpoke Chili";
        }
    }
}

