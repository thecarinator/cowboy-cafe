using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order: INotifyPropertyChanged
    {
        private uint lastOrderNumber;
        public event PropertyChangedEventHandler PropertyChanged;

        private List<IOrderItem> items;
        public IEnumerable<IOrderItem> Items => items.ToArray();
        public double Subtotal { get; }
        public uint OrderNumber { get; }

        public void Add(IOrderItem item)
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }
    }
}
