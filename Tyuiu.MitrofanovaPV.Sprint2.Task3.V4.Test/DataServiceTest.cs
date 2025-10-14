
using Tyuiu.MitrofanovaPV.Sprint2.Task3.V4.Lib;
namespace Tyuiu.MitrofanovaPV.Sprint2.Task3.V4.Test
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 11;
            Assert.AreEqual(res, wait);
        }
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 0.083;
            Assert.AreEqual(res, wait);
        }
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -1;
            double res = ds.Calculate(x);
            double wait = -0.5;
            Assert.AreEqual(res, wait);
        }
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -10;
            double res = ds.Calculate(x);
            double wait = -109.9;
            Assert.AreEqual(res, wait);
        }
    }
}
