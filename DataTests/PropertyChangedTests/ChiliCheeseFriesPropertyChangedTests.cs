using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{
    public class ChiliCheeseFriesPropertyChangedTests
    {
        [Fact]
        public void ChiliCheeseFriesShouldImplementINotifyPropertyChanged()
        {
            var fries = new ChiliCheeseFries();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(fries);
        }
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var fries = new ChiliCheeseFries();
            Assert.PropertyChanged(fries, "Size", () => { fries.Size = Size.Medium; });
        }
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForIsSmall()
        {
            var fries = new ChiliCheeseFries();
            Assert.PropertyChanged(fries, "IsSmall", () => { fries.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForIsMedium()
        {
            var fries = new ChiliCheeseFries();
            Assert.PropertyChanged(fries, "IsMedium", () => { fries.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForIsLarge()
        {
            var fries = new ChiliCheeseFries();
            Assert.PropertyChanged(fries, "IsLarge", () => { fries.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPrice()
        {
            var fries = new ChiliCheeseFries();
            Assert.PropertyChanged(fries, "Price", () => { fries.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForCalories()
        {
            var fries = new ChiliCheeseFries();
            Assert.PropertyChanged(fries, "Calories", () => { fries.Size = Size.Medium; });
        }

        
    }
}
