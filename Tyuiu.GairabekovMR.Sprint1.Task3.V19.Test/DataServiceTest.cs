using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GairabekovMR.Sprint1.Task3.V19.Lib;

namespace Tyuiu.GairabekovMR.Sprint1.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ElephCanMove_ValidMove_ReturnsTrue()
        {
            // Arrange
            DataService ds = new DataService();
            double x1 = 1;
            double y1 = 1;
            double x2 = 2;
            double y2 = 2;

            // Act
            bool result = ds.ElephCanMove(x1, y1, x2, y2);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ElephCanMove_InvalidMove_ReturnsFalse()
        {
            // Arrange
            DataService ds = new DataService();
            double x1 = 1;
            double y1 = 1;
            double x2 = 1;
            double y2 = 3;

            // Act
            bool result = ds.ElephCanMove(x1, y1, x2, y2);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
