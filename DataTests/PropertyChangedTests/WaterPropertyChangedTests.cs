using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{
    public class WaterPropertyChangedTests
    {
        [Fact]
        public void WaterShouldImplementINotifyPropertyChanged()
        {
            var wat = new Water();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(wat);
        }
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var wat = new Water();
            Assert.PropertyChanged(wat, "Size", () => { wat.Size = Size.Medium; });
        }
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForIsSmall()
        {
            var wat = new Water();
            Assert.PropertyChanged(wat, "IsSmall", () => { wat.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForIsMedium()
        {
            var wat = new Water();
            Assert.PropertyChanged(wat, "IsMedium", () => { wat.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForIsLarge()
        {
            var wat = new Water();
            Assert.PropertyChanged(wat, "IsLarge", () => { wat.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPrice()
        {
            var wat = new Water();
            Assert.PropertyChanged(wat, "Price", () => { wat.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForCalories()
        {
            var wat = new Water();
            Assert.PropertyChanged(wat, "Calories", () => { wat.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSpecialInstructions()
        {
            var wat = new Water();
            Assert.PropertyChanged(wat, "SpecialInstructions", () => { wat.Size = Size.Medium; });
        }
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var wat = new Water();
            Assert.PropertyChanged(wat, "Ice", () => { wat.Ice = false; });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForPrice()
        {
            var wat = new Water();
            Assert.PropertyChanged(wat, "Price", () => { wat.Ice = false; });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForCalories()
        {
            var wat = new Water();
            Assert.PropertyChanged(wat, "Calories", () => { wat.Ice = false; });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var wat = new Water();
            Assert.PropertyChanged(wat, "SpecialInstructions", () => { wat.Ice = false; });
        }

        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForLemon()
        {
            var wat = new Water();
            Assert.PropertyChanged(wat, "Lemon", () => { wat.Lemon = true; });
        }

        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForPrice()
        {
            var wat = new Water();
            Assert.PropertyChanged(wat, "Price", () => { wat.Lemon = true; });
        }

        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForCalories()
        {
            var wat = new Water();
            Assert.PropertyChanged(wat, "Calories", () => { wat.Lemon = true; });
        }

        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForSpecialInstructions()
        {
            var wat = new Water();
            Assert.PropertyChanged(wat, "SpecialInstructions", () => { wat.Lemon = true; });
        }
    }
}
