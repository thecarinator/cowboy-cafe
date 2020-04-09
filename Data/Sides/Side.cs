/* Author:
 * Edited By: Cari Miller
 * Class: Side.cs
 * Purpose: Base class for side
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side: INotifyPropertyChanged, IOrderItem
    {
        private Size size;
        /// <summary>
        /// Gets the size of the side
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsSmall"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsMedium"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsLarge"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
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

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the side
        /// </summary>
        public abstract uint Calories { get; }

        public List<string> SpecialInstructions
        {
            get
            {
                return new List<string>();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
