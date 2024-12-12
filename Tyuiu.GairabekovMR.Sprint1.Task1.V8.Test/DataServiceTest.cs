using Tyuiu.GairabekovMR.Sprint1.Task4.V8.Lib;
namespace Tyuiu.GairabekovMR.Sprint1.Task4.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(-0.6, ds.Calculate(-2, 7));
        }
    }
}

