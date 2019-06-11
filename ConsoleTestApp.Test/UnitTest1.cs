using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleTestApp.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //First  
            var result = Trigonometric.TrianlgeSidesInput(10, 10, 15);
            Assert.AreEqual("Isosceles", result);

        }

        [TestMethod]
        public void TestMethod2()
        {
            //Second Test  
            var result = Trigonometric.TrianlgeSidesInput(10.5, 10.5, 15);
            Assert.AreEqual("Isosceles", result);

        }

        [TestMethod]
        public void TestMethod3()
        {
            //Thisrd Test  
            var result  = Trigonometric.TrianlgeSidesInput(10.5, 12.5, 15.5);
            Assert.AreEqual("Scalene", result);

        }
    }
}
