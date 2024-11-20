using Tyuiu.GairabekovMR.Sprint1.Task1.V8.Lib;

namespace Tyuiu.GairabekovMR.Sprint1.Task1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 2.0; // Значение a
            double x = 2.0; // Значение x
            double expected = 3.14; // Ожидаемое значение
            var res = ds.Calculate(a, x); // Фактическое значение
            Assert.AreEqual(expected, res); // Сравниваем без погрешности
        }
    }
}

