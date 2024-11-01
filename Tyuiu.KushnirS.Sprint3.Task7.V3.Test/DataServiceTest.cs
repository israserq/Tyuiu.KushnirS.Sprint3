using Tyuiu.KushnirS.Sprint3.Task7.V3.Lib;
namespace Tyuiu.KushnirS.Sprint3.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;

            double[] waitArray;
            waitArray = new double[len];

            waitArray[0] = 4.34;
            waitArray[1] = 4.16;
            waitArray[2] = 3.71;
            waitArray[3] = 3.27;
            waitArray[4] = 2.93;
            waitArray[5] = 2.5;
            waitArray[6] = 0.71;
            waitArray[7] = -47.61;
            waitArray[8] = 55.15;
            waitArray[9] = 45.17;
            waitArray[10] = 14.97;
            double[] res;
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(waitArray, res);
        }
    }
}