using Tyuiu.GairabekovMR.Sprint1.Task6.V6.Lib;
namespace Tyuiu.GairabekovMR.Sprint1.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string checkstr = "Что упало, то пропало";
            string waitstr = "то пало, о ропало";
            var res = ds.DeleteFirstLetter(checkstr);
            Assert.AreEqual(waitstr, res);

        }
    }
}