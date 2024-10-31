using Tyuiu.KushnirS.Sprint3.Task1.V18.Lib;
namespace Tyuiu.KushnirS.Sprint3.Task1.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
           
            int kEnd = 15, kStart = 1;
            Console.WriteLine("* Начальное k = " + kStart);
            Console.WriteLine("* Конечное k = " + kEnd);
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine(ds.GetSumSeries(kStart, kEnd));
        }
    }
}
