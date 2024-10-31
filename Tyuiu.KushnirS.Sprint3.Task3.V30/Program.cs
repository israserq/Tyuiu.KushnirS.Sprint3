using Tyuiu.KushnirS.Sprint3.Task3.V30.Lib;
namespace Tyuiu.KushnirS.Sprint3.Task3.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
           

            string value = "fyyklbtyn ygrc vfyyyyh";
            char item = 'y';
            Console.WriteLine("Исходная строка = " + value);
            Console.WriteLine("Искомый символ " + item);
            int res = ds.GetMaxCharCount(value, item);
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
