using Tyuiu.GairabekovMR.Sprint1.TaskReview.V9.Lib;

namespace Tyuiu.GairabekovMR.Sprint1.TaskReview.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_ValidExpression_ReturnsExpectedResult()
        {
            
            DataService ds = new DataService();
            double x = 1.0;
            double y = 1.0;
            double expected = 2.073;

            
            double result = ds.Calculate(x,y);

            
            Assert.AreEqual(expected, result);
        }
    }
}
