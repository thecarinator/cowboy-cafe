﻿using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{
    public class CowpokeChiliPropertyChangedTests
    {
        [Fact]
        public void CowpokeChiliShouldImplementINotifyPropertyChanged()
        {
            var chili = new CowpokeChili();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chili);
        }

        [Fact]

        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "Cheese", () => { chili.Cheese = false; });
        }

        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () => { chili.Cheese = false; });
        }

        [Fact]

        public void ChangingSourCreamShouldInvokePropertyChangedForSourCream()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SourCream", () => { chili.SourCream = false; });
        }

        [Fact]
        public void ChangingSourCreamShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () => { chili.SourCream = false; });
        }

        [Fact]

        public void ChangingGreenOnionsShouldInvokePropertyChangedForGreenOnions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "GreenOnions", () => { chili.GreenOnions = false; });
        }

        [Fact]
        public void ChangingGreenOnionsShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () => { chili.GreenOnions = false; });
        }
        [Fact]

        public void ChangingTortillaStripsShouldInvokePropertyChangedForTortillaStrips()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "TortillaStrips", () => { chili.TortillaStrips = false; });
        }

        [Fact]
        public void ChangingTortillaStripsShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () => { chili.TortillaStrips = false; }) ;
        }
    }
}
