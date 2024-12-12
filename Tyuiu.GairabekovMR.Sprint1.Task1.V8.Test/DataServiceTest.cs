using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GairabekovMR.Sprint1.Task4.V8.Lib;

namespace Tyuiu.GairabekovMR.Sprint1.Task4.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 12;
            double y = 3;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(2.6, res);

        }
    }
}

