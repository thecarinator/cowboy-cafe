/* Author: Cari Miller
 * Class: Order.cs
 * Purpose:
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// 
    /// </summary>
    public class Order: INotifyPropertyChanged
    {
        private static uint lastOrderNumber = 1;
        public Order()
        {
            ordernum = lastOrderNumber++;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// 
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
        /// gets the actual total
        /// </summary>
        public double Tax { get { return Subtotal *.16; } }

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
