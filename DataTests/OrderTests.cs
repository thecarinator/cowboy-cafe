using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;

namespace CowboyCafe.DataTests
{
    public class OrderTests
    {
        class MockOrderItem: IOrderItem
        {
            public double Price { get; }
            public List<string> SpecialInstructions { get; }
        }
        // Adding something to the order should
        // have it appear in the Items property
        [Fact]
        public void AddedIOrderItemsAppearInItemsProperty()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            Assert.Contains(item, order.Items);
        }

        public void RemovedORderITemDoesNotAppearInItemsProperty()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            order.Remove(item);
            Assert.DoesNotContain(item, order.Items);
        }

        // Removing something from the order should
        // remove it from the Items property

        // Get the price - needs to be right
        // (For the items we've added)
    }
}
