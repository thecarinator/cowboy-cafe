using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{
    public class DakotaDoubleBurgersPropertyChangedTests
    {
        [Fact]
        public void DakotaDoubleBurgerShouldImplementINotifyPropertyChanged()
        {
            var burg = new DakotaDoubleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(burg);
        }

        [Fact]

        public void ChangingBunShouldInvokePropertyChangedForBun()
        {
            var burg = new DakotaDoubleBurger();
            Assert.PropertyChanged(burg, "Bun", () => { burg.Bun = false; });
        }

        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burg = new DakotaDoubleBurger();
            Assert.PropertyChanged(burg, "SpecialInstructions", () => { burg.Bun = false; });
        }

        [Fact]

        public void ChangingKetchupShouldInvokePropertyChangedForKetchup()
        {
            var burg = new DakotaDoubleBurger();
            Assert.PropertyChanged(burg, "Ketchup", () => { burg.Ketchup = false; });
        }

        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burg = new DakotaDoubleBurger();
            Assert.PropertyChanged(burg, "SpecialInstructions", () => { burg.Ketchup = false; });
        }

        [Fact]

        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var burg = new DakotaDoubleBurger();
            Assert.PropertyChanged(burg, "Cheese", () => { burg.Cheese = false; });
        }

        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burg = new DakotaDoubleBurger();
            Assert.PropertyChanged(burg, "SpecialInstructions", () => { burg.Cheese = false; });
        }

        [Fact]

        public void ChangingMustardShouldInvokePropertyChangedForMustard()
        {
            var burg = new DakotaDoubleBurger();
            Assert.PropertyChanged(burg, "Mustard", () => { burg.Mustard = false; });
        }

        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burg = new DakotaDoubleBurger();
            Assert.PropertyChanged(burg, "SpecialInstructions", () => { burg.Mustard = false; });
        }

        [Fact]

        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var burg = new DakotaDoubleBurger();
            Assert.PropertyChanged(burg, "Pickle", () => { burg.Pickle = false; });
        }

        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burg = new DakotaDoubleBurger();
            Assert.PropertyChanged(burg, "SpecialInstructions", () => { burg.Pickle = false; });
        }

        [Fact]

        public void ChangingLettuceShouldInvokePropertyChangedForLettuce()
        {
            var burg = new DakotaDoubleBurger();
            Assert.PropertyChanged(burg, "Lettuce", () => { burg.Lettuce = false; });
        }

        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burg = new DakotaDoubleBurger();
            Assert.PropertyChanged(burg, "SpecialInstructions", () => { burg.Lettuce = false; });
        }

        [Fact]

        public void ChangingTomatoShouldInvokePropertyChangedForTomato()
        {
            var burg = new DakotaDoubleBurger();
            Assert.PropertyChanged(burg, "Tomato", () => { burg.Tomato = false; });
        }

        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burg = new DakotaDoubleBurger();
            Assert.PropertyChanged(burg, "SpecialInstructions", () => { burg.Tomato = false; });
        }

        [Fact]

        public void ChangingMayoShouldInvokePropertyChangedForMayo()
        {
            var burg = new DakotaDoubleBurger();
            Assert.PropertyChanged(burg, "Mayo", () => { burg.Mayo = false; });
        }

        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burg = new DakotaDoubleBurger();
            Assert.PropertyChanged(burg, "SpecialInstructions", () => { burg.Mayo = false; });
        }
    }
}
