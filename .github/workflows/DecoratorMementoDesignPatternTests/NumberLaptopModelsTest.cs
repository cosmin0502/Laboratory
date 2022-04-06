using Microsoft.VisualStudio.TestTools.UnitTesting;
using DecoratorMementoDesignPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorMementoDesignPattern.Tests
{
    [TestClass()]
    public class NumberLaptopModelsTest
    {
        [TestMethod()]
        public void AddNumberLaptopModelsTest()
        {
            
        }

    }

    [TestClass()]
    public class NumberModelsTestes
    {
        [TestMethod]
        public void Adding_550_and_950_returns1500()
        {
            var numbermodels = new NumberLaptopModels();
            int resultnumbermodels = numbermodels.AddNumberLaptopModels(550, 950);
            Assert.AreEqual<int>(1500, resultnumbermodels);
        }
    }
}