/* Author: Cari Miller
 * Class: Order.cs
 * Purpose: Creates an order
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Order
    /// </summary>
    public class Order: INotifyPropertyChanged
    {
        private static uint lastOrderNumber = 1;
        public Order()
        {
            ordernum = lastOrderNumber++;
        }
        
        /// <summary>
        /// Event of Property changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// List of order items
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// gets list of order items
        /// </summary>
        public IEnumerable<IOrderItem> Items => items.ToArray();
        
        /// <summary>
        /// gets the subtotal
        /// </summary>
        public double Subtotal { 
            get {
                double sub = 0.0;
                foreach(IOrderItem i in items)
                {
                    sub += i.Price;
                }
                return sub;
            } 
        }

        /// <summary>
        /// Gets the tax
        /// </summary>
        public double Tax { get { return Math.Round(Subtotal *.16, 2); } }
        
        /// <summary>
        /// gets the total with tax
        /// </summary>
        public double Total { get { return Subtotal + Tax; } }
        

        private uint ordernum;
        /// <summary>
        /// gets the order number
        /// </summary>
        public uint OrderNumber 
        { 
            get 
            { 
                
                return ordernum; 
            
            } 
        
        }

        /// <summary>
        /// Adds item to order
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            if (item is INotifyPropertyChanged notifier)
            {
                notifier.PropertyChanged += OnItemPropertyChanged;
            }
            
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal")); 
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
        }

        /// <summary>
        /// Removes item from order
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item)
        {
            if (item is INotifyPropertyChanged notifier)
            {
                notifier.PropertyChanged -= OnItemPropertyChanged;
            }
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
        }

        /// <summary>
        /// Property changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if (e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            }
            
        }

    }
}
