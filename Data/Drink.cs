/* Author: Cari Miller
 * Class: Drink.cs
 * Purpose: Base class for drink
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing drink
    /// </summary>
    public abstract class Drink: IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets the size of drink
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// If the drink has ice
        /// </summary>
        public abstract bool Ice { get; set; }

        /// <summary>
        /// Special instruction for drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// gets the price of drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }
    }
}
