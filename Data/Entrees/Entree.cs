/* Author: Cari Miller
 * Class: Entree.cs
 * Purpose: Base class for entree
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing an entree
    /// </summary>
    public abstract class Entree:IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets the The name of the item
        /// </summary>
        public string ItemName => ToString();
        /// <summary>
        /// gets the price of the entree
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// gets the calories of the  entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// gets the special instructions for the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// Event of property change
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        
        /// <summary>
        /// Notification of Property change
        /// </summary>
        /// <param name="propertyName">the property being changed</param>
        protected void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }
    }
}

