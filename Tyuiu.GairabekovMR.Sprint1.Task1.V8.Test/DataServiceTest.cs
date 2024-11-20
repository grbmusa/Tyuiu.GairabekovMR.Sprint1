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
            double a = 2.0; // �������� a
            double x = 2.0; // �������� x
            double expected = 3.14; // ��������� ��������
            var res = ds.Calculate(a, x); // ����������� ��������
            Assert.AreEqual(expected, res); // ���������� ��� �����������
        }
    }
}

