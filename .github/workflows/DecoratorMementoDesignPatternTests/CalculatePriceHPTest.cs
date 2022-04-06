using Microsoft.VisualStudio.TestTools.UnitTesting;
using DecoratorMementoDesignPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorMementoDesignPattern.Tests
{
    [TestClass()]
    public class CalculatePriceHPTest
    {
        [TestMethod()]
        public void AddHPLaptopTest()
        {
            
        }
    }

    [TestClass()]
    public class CaculateTests
    {
        [TestMethod]
        public void Adding_1000_and_1500_returns2500()
        {
            var calculate = new CalculatePriceHP();
            int result = calculate.AddHPLaptop(1000, 1500);
            Assert.AreEqual<int>(2500, result);
        }
    }
}