using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{
    public class PanDeCampoPropertyChangedTests
    {
        [Fact]
        public void PanDeCampoShouldImplementINotifyPropertyChanged()
        {
            var pan = new PanDeCampo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pan);
        }
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var pan = new PanDeCampo();
            Assert.PropertyChanged(pan, "Size", () => { pan.Size = Size.Medium; });
        }
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForIsSmall()
        {
            var pan = new PanDeCampo();
            Assert.PropertyChanged(pan, "IsSmall", () => { pan.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForIsMedium()
        {
            var pan = new PanDeCampo();
            Assert.PropertyChanged(pan, "IsMedium", () => { pan.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForIsLarge()
        {
            var pan = new PanDeCampo();
            Assert.PropertyChanged(pan, "IsLarge", () => { pan.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPrice()
        {
            var pan = new PanDeCampo();
            Assert.PropertyChanged(pan, "Price", () => { pan.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForCalories()
        {
            var pan = new PanDeCampo();
            Assert.PropertyChanged(pan, "Calories", () => { pan.Size = Size.Medium; });
        }
    }
}
