using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;


namespace CowboyCafe.DataTests
{
    
    public class OrderPropertyChangedTests
    {

        [Fact]
        public void OrderShouldImplementINotifyPropertyChanged()
        {
            var ord = new Order();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ord);
        }

        [Fact]
        public void AddingToOrderShouldInvokePropertyChangedForItems()
        {
            var ord = new Order();
            var chicken = new AngryChicken();
            Assert.PropertyChanged(ord, "Items", () => { ord.Add((IOrderItem)chicken); });
        }
        [Fact]
        public void AddingToOrderShouldInvokePropertyChangedForTax()
        {
            var ord = new Order();
            var chicken = new AngryChicken();
            Assert.PropertyChanged(ord, "Tax", () => { ord.Add((IOrderItem)chicken); });
        }
        [Fact]
        public void AddingToOrderShouldInvokePropertyChangedForTotal()
        {
            var ord = new Order();
            var chicken = new AngryChicken();
            Assert.PropertyChanged(ord, "Total", () => { ord.Add((IOrderItem)chicken); });
        }
        [Fact]
        public void AddingToOrderShouldInvokePropertyChangedForSubTotal()
        {
            var ord = new Order();
            var chicken = new AngryChicken();
            Assert.PropertyChanged(ord, "Subtotal", () => { ord.Add((IOrderItem)chicken); });
        }

        [Fact]
        public void RemovingFromOrderShouldInvokePropertyChangedForItems()
        {
            var ord = new Order();
            var chicken = new AngryChicken();
            ord.Add((IOrderItem)chicken);
            Assert.PropertyChanged(ord, "Items", () => { ord.Remove((IOrderItem)chicken); });
        }
        [Fact]
        public void RemovingFromOrderShouldInvokePropertyChangedForSubTotal()
        {
            var ord = new Order();
            var chicken = new AngryChicken();
            ord.Add((IOrderItem)chicken);
            Assert.PropertyChanged(ord, "Subtotal", () => { ord.Remove((IOrderItem)chicken); });
        }
        [Fact]
        public void RemovingFromOrderShouldInvokePropertyChangedForTax()
        {
            var ord = new Order();
            var chicken = new AngryChicken();
            ord.Add((IOrderItem)chicken);
            Assert.PropertyChanged(ord, "Tax", () => { ord.Remove((IOrderItem)chicken); });
        }
        [Fact]
        public void RemovingFromOrderShouldInvokePropertyChangedForTotal()
        {
            var ord = new Order();
            var chicken = new AngryChicken();
            ord.Add((IOrderItem)chicken);
            Assert.PropertyChanged(ord, "Total", () => { ord.Remove((IOrderItem)chicken); });
        }
    }
}
