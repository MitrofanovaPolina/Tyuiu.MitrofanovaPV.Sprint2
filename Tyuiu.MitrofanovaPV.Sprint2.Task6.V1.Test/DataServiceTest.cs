using Tyuiu.MitrofanovaPV.Sprint2.Task6.V1.Lib;
namespace Tyuiu.MitrofanovaPV.Sprint2.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(28, ds.FindMonthDaysCount(2));
        }
    }
}
