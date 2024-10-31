using Tyuiu.KushnirS.Sprint3.Task4.V23.Lib;
namespace Tyuiu.KushnirS.Sprint3.Task4.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
           
            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("Старт шага: " + startValue);
            Console.WriteLine("Конец шага: " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Произведение ряда равно " + ds.Calculate(startValue, stopValue));
        }
    }
}
