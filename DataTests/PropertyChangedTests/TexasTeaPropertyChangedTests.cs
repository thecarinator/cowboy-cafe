using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{
    public class TexasTeaPropertyChangedTests
    {
        [Fact]
        public void TexasTeaShouldImplementINotifyPropertyChanged()
        {
            var tea = new TexasTea();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(tea);
        }
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Size", () => { tea.Size = Size.Medium; });
        }
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForIsSmall()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "IsSmall", () => { tea.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForIsMedium()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "IsMedium", () => { tea.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForIsLarge()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "IsLarge", () => { tea.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPrice()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Price", () => { tea.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForCalories()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Calories", () => { tea.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () => { tea.Size = Size.Medium; });
        }
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Ice", () => { tea.Ice = false; });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForPrice()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Price", () => { tea.Ice = false; });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForCalories()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Calories", () => { tea.Ice = false; });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () => { tea.Ice = false; });
        }

        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForLemon()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Lemon", () => { tea.Lemon = true; });
        }

        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForPrice()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Price", () => { tea.Lemon = true; });
        }

        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForCalories()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Calories", () => { tea.Lemon = true; });
        }

        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () => { tea.Lemon = true; });
        }

        [Fact]
        public void ChangingSweetShouldInvokePropertyChangedForSweet()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Sweet", () => { tea.Sweet = false; });
        }

        [Fact]
        public void ChangingSweetShouldInvokePropertyChangedForPrice()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Price", () => { tea.Sweet = false; });
        }

        [Fact]
        public void ChangingSweetShouldInvokePropertyChangedForCalories()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Calories", () => { tea.Sweet = false; });
        }

        [Fact]
        public void ChangingSweetShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () => { tea.Sweet = false; });
        }
    }
}
