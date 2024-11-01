using Tyuiu.KushnirS.Sprint3.Task6.V7.Lib;
namespace Tyuiu.KushnirS.Sprint3.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 17;
            int stopValue = 26;
            double res = ds.GetSumTheDivisors(startValue, stopValue);
            Assert.AreEqual(344, res);
        }
    }
}