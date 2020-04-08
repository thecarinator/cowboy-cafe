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
        private Size size;
        /// <summary>
        /// Gets the size of drink
        /// </summary>
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                NotifyOfPropertyChange("Size");
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsSmall"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsMedium"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsLarge"));
            }
        }

       
        public bool IsSmall
        {
            get { return Size == Size.Small; }
            set { Size = Size.Small; }
        }
        public bool IsMedium
        {
            get { return Size == Size.Medium; }
            set { Size = Size.Medium; }
        }
        public bool IsLarge
        {
            get { return Size == Size.Large; }
            set { Size = Size.Large; }
        }

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
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));

        }
    }
}
