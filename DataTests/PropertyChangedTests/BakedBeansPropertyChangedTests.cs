using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{
    public class BakedBeansPropertyChangedTests
    {
        [Fact]
        public void BakedBeansShouldImplementINotifyPropertyChanged()
        {
            var beans = new BakedBeans();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(beans);
        }
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var beans = new BakedBeans();
            Assert.PropertyChanged(beans, "Size", () => { beans.Size = Size.Medium; });
        }
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForIsSmall()
        {
            var beans = new BakedBeans();
            Assert.PropertyChanged(beans, "IsSmall", () => { beans.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForIsMedium()
        {
            var beans = new BakedBeans();
            Assert.PropertyChanged(beans, "IsMedium", () => { beans.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForIsLarge()
        {
            var beans = new BakedBeans();
            Assert.PropertyChanged(beans, "IsLarge", () => { beans.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPrice()
        {
            var beans = new BakedBeans();
            Assert.PropertyChanged(beans, "Price", () => { beans.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForCalories()
        {
            var beans = new BakedBeans();
            Assert.PropertyChanged(beans, "Calories", () => { beans.Size = Size.Medium; });
        }

    }
}
