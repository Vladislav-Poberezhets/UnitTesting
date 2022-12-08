using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTesting;



namespace UnitTesting.Tests
{
    [TestClass]
    public class MyCalcTests
    {
        [TestMethod]
        public void Sum_10and5_15returned()
        {
            int x = 10;
            int y = 5;
            int expected = 15;

            MyCalc c = new MyCalc();
            int actual = c.Sum(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Subsraction_10and5_5returned()
        {
            int x = 10;
            int y = 5;
            int expected = 5;

            MyCalc c = new MyCalc();
            int actual = c.Subtraction(x, y);

            Assert.AreEqual(expected, actual);
        }
        
        
    }
   
    
}
