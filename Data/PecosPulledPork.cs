﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the Pecos Pulled Pork entree
    /// </summary>
    public class PecosPulledPork
    {
        private bool bread = true;

        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }

        private bool pickles = true;

        public bool Pickle
        {
            get { return pickles; }
            set { pickles = value; }
        }

        public double Price
        {
            get { return 5.88; }
        }

        public uint Calories
        {
            get { return 528; }
        }

        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (!bread) instructions.Add("hold bread");
                if (!pickles) instructions.Add("hold pickle");
                return instructions;
            }
        }
    }
}

