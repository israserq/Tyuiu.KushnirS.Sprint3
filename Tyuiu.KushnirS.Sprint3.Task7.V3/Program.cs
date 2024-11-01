using Tyuiu.KushnirS.Sprint3.Task7.V3.Lib;
namespace Tyuiu.KushnirS.Sprint3.Task7.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = -5;
            int y = 5;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(x);
            Console.WriteLine(y);

            int len = ds.GetMassFunction(x, y).Length;
            double[] valueArray;
            valueArray = new double[len];

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("+|    X    |   f(x)  |+");
            Console.WriteLine("+----------+----------+");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("| {0,5:d}    |  {1, 5:f2}   |", x, valueArray[i]);
                x++;
            }
            Console.WriteLine("+----------+----------+");
            Console.ReadKey();
        }
    }
}
