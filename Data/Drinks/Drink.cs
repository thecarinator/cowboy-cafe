/* Author: Cari Miller
 * Class: Drink.cs
 * Purpose: Base class for drink
 */

using System.Collections.Generic;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing drink
    /// </summary>
    public abstract class Drink : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets the The name of the item
        /// </summary>
        public string ItemName => ToString();
        private Size size;
        /// <summary>
        /// Gets the size of drink
        /// </summary>
        public virtual Size Size
        {
            get
            {
                return size;
            } 
            set
            {
                if (size == value) return;
                size = value;
                NotifyOfPropertyChange("Size");
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsSmall"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsMedium"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsLarge"));
            }
        }

        private SodaFlavor flavor;
        /// <summary>
        /// Flavor of soda
        /// </summary>
        public virtual SodaFlavor Flavor
        {
            get { return flavor; }
            set
            {
                if (flavor == value) return;
                flavor = value;
                NotifyOfPropertyChange("Flavor");
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsCreamSoda"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsOrangeSoda"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsRootBeer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsBirchBeer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsSarsparilla"));
            }
        }

        /// <summary>
        /// Checks if soda is cream soda
        /// </summary>
        public bool IsCreamSoda
        {
            get { return Flavor == SodaFlavor.CreamSoda; }
            set
            {
                if (Flavor == SodaFlavor.CreamSoda) return;
                Flavor = SodaFlavor.CreamSoda;
            }
        }

        /// <summary>
        /// Checks if soda is orange soda
        /// </summary>
        public bool IsOrangeSoda
        {
            get { return Flavor == SodaFlavor.OrangeSoda; }
            set
            {
                if (Flavor == SodaFlavor.OrangeSoda) return;
                Flavor = SodaFlavor.OrangeSoda;
            }
        }

        /// <summary>
        /// Checks if soda is sarsparilla
        /// </summary>
        public bool IsSarsparilla
        {
            get { return Flavor == SodaFlavor.Sarsparilla; }
            set
            {
                if (Flavor == SodaFlavor.Sarsparilla) return;
                Flavor = SodaFlavor.Sarsparilla;
            }
        }

        /// <summary>
        /// Checks if soda is birch beer
        /// </summary>
        public bool IsBirchBeer
        {
            get { return Flavor == SodaFlavor.BirchBeer; }
            set
            {
                if (Flavor == SodaFlavor.BirchBeer) return;
                Flavor = SodaFlavor.BirchBeer;
            }
        }

        /// <summary>
        /// Checks if soda is root beer
        /// </summary>
        public bool IsRootBeer
        {
            get { return Flavor == SodaFlavor.RootBeer; }
            set
            {
                if (Flavor == SodaFlavor.RootBeer) return;
                Flavor = SodaFlavor.RootBeer;
            }
        }
        /// <summary>
        /// Checks if the drink is a small
        /// </summary> =
        public bool IsSmall
        {
            get { return Size == Size.Small; }
            set 
            {
                if (Size == Size.Small) return;
                Size = Size.Small; 
            }
        }

        /// <summary>
        /// Checks if the drink is a medium
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
        /// Checks if the drink is a large
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

        /// <summary>
        /// Event of Property Change
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Notifying of Property Changes
        /// </summary>
        /// <param name="propertyName">property being changed</param>
        protected void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));

        }
    }
}
