using System;
using Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorUnitTest
{
    [TestClass]
    public class CalculatorEngineUnitTest
    {
        /// <summary>
        /// Function to Addition
        /// </summary>
        [TestMethod]
        public void TestMethodAdd()
        {
            int a = 1;
            int b = 2;
            int expected = 3;

            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Add(a, b);

            Assert.AreEqual(expected, actual);
        }
    
    
    
    
        [TestMethod]
        public void TestMethodSub()
        {
            int a = 6;
            int b = 3;
            int expected = 3;

            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Sub(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodMul()
        {
            int a = 2;
            int b = 3;
            int expected = 6;

            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Mul(a, b);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void TestMethodDivByZero()
        {
            int a = 6;
            int b = 0;
            int expected = Int32.MinValue;

            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Div(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodDiv()
        {
            int a = 6;
            int b = 3;
            int expected = 2;

            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Div(a, b);

            Assert.AreEqual(expected, actual);
        }

    }

  
} 
