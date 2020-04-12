using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{
    public class TrailBurgerPropertyChangedTests
    {
        [Fact]
        public void TrailBurgerShouldImplementINotifyPropertyChanged()
        {
            var burg = new TrailBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(burg);
        }

        [Fact]

        public void ChangingBunShouldInvokePropertyChangedForBun()
        {
            var burg = new TrailBurger();
            Assert.PropertyChanged(burg, "Bun", () => { burg.Bun = false; });
        }

        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burg = new TrailBurger();
            Assert.PropertyChanged(burg, "SpecialInstructions", () => { burg.Bun = false; });
        }

        [Fact]

        public void ChangingKetchupShouldInvokePropertyChangedForKetchup()
        {
            var burg = new TrailBurger();
            Assert.PropertyChanged(burg, "Ketchup", () => { burg.Ketchup = false; });
        }

        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burg = new TrailBurger();
            Assert.PropertyChanged(burg, "SpecialInstructions", () => { burg.Ketchup = false; });
        }

        [Fact]

        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var burg = new TrailBurger();
            Assert.PropertyChanged(burg, "Cheese", () => { burg.Cheese = false; });
        }

        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burg = new TrailBurger();
            Assert.PropertyChanged(burg, "SpecialInstructions", () => { burg.Cheese = false; });
        }

        [Fact]

        public void ChangingMustardShouldInvokePropertyChangedForMustard()
        {
            var burg = new TrailBurger();
            Assert.PropertyChanged(burg, "Mustard", () => { burg.Mustard = false; });
        }

        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burg = new TrailBurger();
            Assert.PropertyChanged(burg, "SpecialInstructions", () => { burg.Mustard = false; });
        }

        [Fact]

        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var burg = new TrailBurger();
            Assert.PropertyChanged(burg, "Pickle", () => { burg.Pickle = false; });
        }

        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burg = new TrailBurger();
            Assert.PropertyChanged(burg, "SpecialInstructions", () => { burg.Pickle = false; });
        }
    }
}
