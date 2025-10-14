using Tyuiu.MitrofanovaPV.Sprint2.Task5.V12.Lib;
namespace Tyuiu.MitrofanovaPV.Sprint2.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int n = 13;
            int m = 5;
            int g = 25;
            var res = ds.FindDateOfPreviousDay(n, m, g);
            var wait = "12.5.25";
            Assert.AreEqual(res, wait);
        }
    }
}
