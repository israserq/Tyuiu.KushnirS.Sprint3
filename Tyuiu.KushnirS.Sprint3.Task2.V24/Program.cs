using Tyuiu.KushnirS.Sprint3.Task2.V24.Lib;
namespace Tyuiu.KushnirS.Sprint3.Task2.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            double value = 0.25;
            int startValue = 1;
            int stopValue = 8;
            Console.WriteLine("Перемнная x = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = Convert.ToDouble(ds.GetMultiplySeries(value, startValue, stopValue));
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
