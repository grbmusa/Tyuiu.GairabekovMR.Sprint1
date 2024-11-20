using Tyuiu.GairabekovMR.Sprint1.Task2.V28.Lib;

namespace Tyuiu.GairabekovMR.Sprint1.Task2.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ConvertCelsiusToKelvin_ValidInput_ReturnsCorrectResult()
        {
            // Arrange
            DataService ds = new DataService();
            int celsius = 25;
            int expectedKelvin = 298;

            // Act
            int result = ds.ConvertCelsiusToKelvin(celsius);

            // Assert
            Assert.AreEqual(expectedKelvin, result);
        }
    }
}
