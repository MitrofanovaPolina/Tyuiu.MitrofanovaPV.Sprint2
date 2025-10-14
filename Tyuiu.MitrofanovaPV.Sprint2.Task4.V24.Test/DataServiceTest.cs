using Tyuiu.MitrofanovaPV.Sprint2.Task4.V24.Lib;
namespace Tyuiu.MitrofanovaPV.Sprint2.Task4.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 24;
            double y = 1;
            double res = ds.Calculate(x,y);
            double wait = 4.421;
            Assert.AreEqual(res, wait);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 0;
            double res = ds.Calculate(x, y);
            double wait = 0.833;
            Assert.AreEqual(res, wait);
        }
    }
}
