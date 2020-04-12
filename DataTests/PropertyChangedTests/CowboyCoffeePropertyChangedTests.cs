using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{
    public class CowboyCoffeePropertyChangedTests
    {
        [Fact]
        public void CowboyCoffeeShouldImplementINotifyPropertyChanged()
        {
            var cafe = new CowboyCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(cafe);
        }
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var cafe = new CowboyCoffee();
            Assert.PropertyChanged(cafe, "Size", () => { cafe.Size = Size.Medium; });
        }
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForIsSmall()
        {
            var cafe = new CowboyCoffee();
            Assert.PropertyChanged(cafe, "IsSmall", () => { cafe.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForIsMedium()
        {
            var cafe = new CowboyCoffee();
            Assert.PropertyChanged(cafe, "IsMedium", () => { cafe.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForIsLarge()
        {
            var cafe = new CowboyCoffee();
            Assert.PropertyChanged(cafe, "IsLarge", () => { cafe.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPrice()
        {
            var cafe = new CowboyCoffee();
            Assert.PropertyChanged(cafe, "Price", () => { cafe.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForCalories()
        {
            var cafe = new CowboyCoffee();
            Assert.PropertyChanged(cafe, "Calories", () => { cafe.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cafe = new CowboyCoffee();
            Assert.PropertyChanged(cafe, "SpecialInstructions", () => { cafe.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var cafe = new CowboyCoffee();
            Assert.PropertyChanged(cafe, "Ice", () => { cafe.Ice = true; });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForPrice()
        {
            var cafe = new CowboyCoffee();
            Assert.PropertyChanged(cafe, "Price", () => { cafe.Ice = true; });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForCalories()
        {
            var cafe = new CowboyCoffee();
            Assert.PropertyChanged(cafe, "Calories", () => { cafe.Ice = true; });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cafe = new CowboyCoffee();
            Assert.PropertyChanged(cafe, "SpecialInstructions", () => { cafe.Ice = true; });
        }

        [Fact]
        public void ChangingDecafShouldInvokePropertyChangedForDecaf()
        {
            var cafe = new CowboyCoffee();
            Assert.PropertyChanged(cafe, "Decaf", () => { cafe.Decaf = true; });
        }

        [Fact]
        public void ChangingDecafShouldInvokePropertyChangedForPrice()
        {
            var cafe = new CowboyCoffee();
            Assert.PropertyChanged(cafe, "Price", () => { cafe.Decaf = true; });
        }

        [Fact]
        public void ChangingDecafShouldInvokePropertyChangedForCalories()
        {
            var cafe = new CowboyCoffee();
            Assert.PropertyChanged(cafe, "Calories", () => { cafe.Decaf = true; });
        }

        [Fact]
        public void ChangingDecafShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cafe = new CowboyCoffee();
            Assert.PropertyChanged(cafe, "SpecialInstructions", () => { cafe.Decaf = true; });
        }

        [Fact]
        public void ChangingRoomForCreamShouldInvokePropertyChangedForRoomForCream()
        {
            var cafe = new CowboyCoffee();
            Assert.PropertyChanged(cafe, "RoomForCream", () => { cafe.RoomForCream = true; });
        }

        [Fact]
        public void ChangingRoomForCreamShouldInvokePropertyChangedForPrice()
        {
            var cafe = new CowboyCoffee();
            Assert.PropertyChanged(cafe, "Price", () => { cafe.RoomForCream = true; });
        }

        [Fact]
        public void ChangingRoomForCreamShouldInvokePropertyChangedForCalories()
        {
            var cafe = new CowboyCoffee();
            Assert.PropertyChanged(cafe, "Calories", () => { cafe.RoomForCream = true; });
        }

        [Fact]
        public void ChangingRoomForCreamShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cafe = new CowboyCoffee();
            Assert.PropertyChanged(cafe, "SpecialInstructions", () => { cafe.RoomForCream = true; });
        }
    }
}
