using Tyuiu.KushnirS.Sprint3.Task1.V18.Lib;
namespace Tyuiu.KushnirS.Sprint3.Task1.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetSumSeries()
        {
            DataService ds = new DataService();
            int s = 1, st = 2;
            Assert.AreEqual(ds.GetSumSeries(s, st), 0.109);
        }
    }
}