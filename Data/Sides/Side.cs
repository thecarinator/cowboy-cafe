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
        private Size size = Size.Small;
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
                if (size == value) return;
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsSmall"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsMedium"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsLarge"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            } 
        }

        /// <summary>
        /// Checks if the side is a small
        /// </summary> =
        public bool IsSmall
        {
            get { return (Size == Size.Small); }
            set
            {
                if (Size == Size.Small) return;
                Size = Size.Small;
            }
        }

        /// <summary>
        /// Checks if the side is a medium
        /// </summary>
        public bool IsMedium
        {
            get { return Size == Size.Medium; }
            set
            {
                if (Size == Size.Medium) return;
                Size = Size.Medium;
            }
        }

        
        /// <summary>
        /// Checks if the side is a large
        /// </summary>
        public bool IsLarge
        {
            get { return Size == Size.Large; }
            set
            {
                if (Size == Size.Large) return;
                Size = Size.Large;
            }
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
