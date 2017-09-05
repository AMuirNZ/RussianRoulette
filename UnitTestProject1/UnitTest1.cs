using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RussianRoulette;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void awayTrueOrFalse()
        {
            Calculate myCalc = new Calculate();

            bool Actual = myCalc.awayTrueOrFalse(1);
            Assert.AreEqual(true, Actual);
                
        }

      

        [TestMethod]
        public void awayAdded()
        {
            Calculate myCalc = new Calculate();

            int Actual = myCalc.awayAdded(1);
            Assert.AreEqual(1, Actual);
        }
    }
}
