using Tyuiu.KushnirS.Sprint3.Task6.V8.Lib;
namespace Tyuiu.KushnirS.Sprint3.Task6.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

           
            Console.WriteLine("***************************************************************************");

            int startValue = 17;
            int stopValue = 26;
            Console.WriteLine("Начало отрезка = " + startValue);
            Console.WriteLine("Конец отрезка = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма делителей = " + ds.GetSumTheDivisors(startValue, stopValue));
        }
    }
}
