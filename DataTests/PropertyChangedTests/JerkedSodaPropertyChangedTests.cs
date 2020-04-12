using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{
    public class JerkedSodaPropertyChangedTests
    {
        [Fact]
        public void JerkedSodaShouldImplementINotifyPropertyChanged()
        {
            var soda = new JerkedSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(soda);
        }
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Size", () => { soda.Size = Size.Medium; });
        }
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForIsSmall()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "IsSmall", () => { soda.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForIsMedium()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "IsMedium", () => { soda.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForIsLarge()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "IsLarge", () => { soda.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPrice()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Price", () => { soda.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForCalories()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Calories", () => { soda.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSpecialInstructions()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "SpecialInstructions", () => { soda.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Ice", () => { soda.Ice = false; });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForPrice()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Price", () => { soda.Ice = false; });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForCalories()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Calories", () => { soda.Ice = false; });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "SpecialInstructions", () => { soda.Ice = false; });
        }

        [Fact]
        public void ChangingFlavorShouldInvokePropertyChangedForFlavor()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Flavor", () => { soda.Flavor = SodaFlavor.OrangeSoda; });
        }

        [Fact]
        public void ChangingFlavorShouldInvokePropertyChangedForIsCreamSoda()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "IsCreamSoda", () => { soda.Flavor = SodaFlavor.OrangeSoda; });
        }

        [Fact]
        public void ChangingFlavorShouldInvokePropertyChangedForIsOrangeSoda()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "IsOrangeSoda", () => { soda.Flavor = SodaFlavor.OrangeSoda; });
        }
        [Fact]
        public void ChangingFlavorShouldInvokePropertyChangedForIsSarsparilla()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "IsSarsparilla", () => { soda.Flavor = SodaFlavor.Sarsparilla; });
        }
        [Fact]
        public void ChangingFlavorShouldInvokePropertyChangedForIsBirchBeer()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "IsBirchBeer", () => { soda.Flavor = SodaFlavor.OrangeSoda; });
        }

        [Fact]
        public void ChangingFlavorShouldInvokePropertyChangedForIsRootBeer()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "IsRootBeer", () => { soda.Flavor = SodaFlavor.OrangeSoda; });
        }
        [Fact]
        public void ChangingFlavorShouldInvokePropertyChangedForPrice()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Price", () => { soda.Flavor = SodaFlavor.OrangeSoda; });
        }

        [Fact]
        public void ChangingFlavorShouldInvokePropertyChangedForCalories()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Calories", () => { soda.Flavor = SodaFlavor.OrangeSoda; });
        }

        [Fact]
        public void ChangingFlavorShouldInvokePropertyChangedForSpecialInstructions()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "SpecialInstructions", () => { soda.Flavor = SodaFlavor.OrangeSoda; });
        }

    }
}
