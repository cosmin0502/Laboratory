using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proiect2_StrategyPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect2_StrategyPattern.Tests
{
    [TestClass()]
    public class VikingTests
    {
        [TestMethod()]
        public void _0_WalkMove()
        {
            IUnit viking = new Viking();

            viking.Move();
            Assert.AreEqual(1, viking.Position);
            viking.Move();
            Assert.AreEqual(2, viking.Position);            
        }

        public void FlyMove()
        {
            IUnit viking = new Viking();
            viking.MoveBehavior = new Fly();

            viking.Move();
            Assert.AreEqual(10, viking.Position);
            viking.Move();
            Assert.AreEqual(20, viking.Position);
        }

        public void _2_MixMove()
        {
            IUnit viking = new Viking();

            viking.Move();
            Assert.AreEqual(1, viking.Position);

            viking.MoveBehavior = new Fly();
            viking.Move();
            Assert.AreEqual(11, viking.Position);
        }
    }
}