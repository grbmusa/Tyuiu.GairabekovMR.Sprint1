using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GairabekovMR.Sprint1.Task7.V5.Lib;

namespace Tyuiu.GairabekovMR.Sprint1.Task7.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_ValidExpression_ReturnsExpectedResult()
        {
            // Arrange
            DataService ds = new DataService();
            double x = 1.0; // Пример значения для теста
            double expected = Math.Round(Math.Log(Math.Abs(Math.Cos(x))) / Math.Log(1 + x * x), 3);

            // Act
            double result = ds.Calculate(x);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
