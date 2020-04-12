using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{
    public class CornDodgersPropertyChangedTests
    {
        [Fact]
        public void CornDodgersShouldImplementINotifyPropertyChanged()
        {
            var corn = new CornDodgers();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(corn);
        }
       [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var corn = new CornDodgers();
            Assert.PropertyChanged(corn, "Size", () => { corn.Size = Size.Medium; });
        }
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForIsSmall()
        {
            var corn = new CornDodgers();
            Assert.PropertyChanged(corn, "IsSmall", () => { corn.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForIsMedium()
        {
            var corn = new CornDodgers();
            Assert.PropertyChanged(corn, "IsMedium", () => { corn.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForIsLarge()
        {
            var corn = new CornDodgers();
            Assert.PropertyChanged(corn, "IsLarge", () => { corn.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPrice()
        {
            var corn = new CornDodgers();
            Assert.PropertyChanged(corn, "Price", () => { corn.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForCalories()
        {
            var corn = new CornDodgers();
            Assert.PropertyChanged(corn, "Calories", () => { corn.Size = Size.Medium; });
        }

    }
}
