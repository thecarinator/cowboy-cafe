using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{
    public class TexasTripleBurgerPropertyChangedTests
    {
        [Fact]
        public void TexasTripleBurgerShouldImplementINotifyPropertyChanged()
        {
            var burg = new TexasTripleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(burg);
        }

        [Fact]

        public void ChangingBunShouldInvokePropertyChangedForBun()
        {
            var burg = new TexasTripleBurger();
            Assert.PropertyChanged(burg, "Bun", () => { burg.Bun = false; });
        }

        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burg = new TexasTripleBurger();
            Assert.PropertyChanged(burg, "SpecialInstructions", () => { burg.Bun = false; });
        }

        [Fact]

        public void ChangingKetchupShouldInvokePropertyChangedForKetchup()
        {
            var burg = new TexasTripleBurger();
            Assert.PropertyChanged(burg, "Ketchup", () => { burg.Ketchup = false; });
        }

        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burg = new TexasTripleBurger();
            Assert.PropertyChanged(burg, "SpecialInstructions", () => { burg.Ketchup = false; });
        }

        [Fact]

        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var burg = new TexasTripleBurger();
            Assert.PropertyChanged(burg, "Cheese", () => { burg.Cheese = false; });
        }

        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burg = new TexasTripleBurger();
            Assert.PropertyChanged(burg, "SpecialInstructions", () => { burg.Cheese = false; });
        }

        [Fact]

        public void ChangingMustardShouldInvokePropertyChangedForMustard()
        {
            var burg = new TexasTripleBurger();
            Assert.PropertyChanged(burg, "Mustard", () => { burg.Mustard = false; });
        }

        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burg = new TexasTripleBurger();
            Assert.PropertyChanged(burg, "SpecialInstructions", () => { burg.Mustard = false; });
        }

        [Fact]

        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var burg = new TexasTripleBurger();
            Assert.PropertyChanged(burg, "Pickle", () => { burg.Pickle = false; });
        }

        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burg = new TexasTripleBurger();
            Assert.PropertyChanged(burg, "SpecialInstructions", () => { burg.Pickle = false; });
        }

        [Fact]

        public void ChangingLettuceShouldInvokePropertyChangedForLettuce()
        {
            var burg = new TexasTripleBurger();
            Assert.PropertyChanged(burg, "Lettuce", () => { burg.Lettuce = false; });
        }

        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burg = new TexasTripleBurger();
            Assert.PropertyChanged(burg, "SpecialInstructions", () => { burg.Lettuce = false; });
        }

        [Fact]

        public void ChangingTomatoShouldInvokePropertyChangedForTomato()
        {
            var burg = new TexasTripleBurger();
            Assert.PropertyChanged(burg, "Tomato", () => { burg.Tomato = false; });
        }

        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burg = new TexasTripleBurger();
            Assert.PropertyChanged(burg, "SpecialInstructions", () => { burg.Tomato = false; });
        }

        [Fact]

        public void ChangingMayoShouldInvokePropertyChangedForMayo()
        {
            var burg = new TexasTripleBurger();
            Assert.PropertyChanged(burg, "Mayo", () => { burg.Mayo = false; });
        }

        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burg = new TexasTripleBurger();
            Assert.PropertyChanged(burg, "SpecialInstructions", () => { burg.Mayo = false; });
        }

        [Fact]

        public void ChangingBaconShouldInvokePropertyChangedForBacon()
        {
            var burg = new TexasTripleBurger();
            Assert.PropertyChanged(burg, "Bacon", () => { burg.Bacon = false; });
        }

        [Fact]
        public void ChangingBaconShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burg = new TexasTripleBurger();
            Assert.PropertyChanged(burg, "SpecialInstructions", () => { burg.Bacon = false; });
        }

        [Fact]

        public void ChangingEggShouldInvokePropertyChangedForEgg()
        {
            var burg = new TexasTripleBurger();
            Assert.PropertyChanged(burg, "Egg", () => { burg.Egg = false; });
        }

        [Fact]
        public void ChangingEggShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burg = new TexasTripleBurger();
            Assert.PropertyChanged(burg, "SpecialInstructions", () => { burg.Egg = false; });
        }
    }
}
