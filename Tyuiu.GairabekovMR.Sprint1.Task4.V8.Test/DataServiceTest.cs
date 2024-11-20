using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GairabekovMR.Sprint1.Task4.V8.Lib;

namespace Tyuiu.GairabekovMR.Sprint1.Task4.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_ValidExpression_ReturnsExpectedResult()
        {
            // Arrange
            DataService ds = new DataService();
            double x = 3.0;
            double y = -1.0;
            double expected = -0.6;

            // Act
            double result = ds.Calculate(x, y);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}







