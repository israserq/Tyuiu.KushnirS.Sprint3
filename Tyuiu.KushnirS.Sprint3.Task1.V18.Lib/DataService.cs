using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KushnirS.Sprint3.Task1.V18.Lib
{
    public class DataService : ISprint3Task1V18
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sym = 0;

            while (startValue <= stopValue)
            {
                sym += ((Math.Sin(startValue)) * (Math.Pow((1.0 / 4.0), 2)));
                startValue++;
            }
            return Math.Round(sym, 3);
        }
    }
}
