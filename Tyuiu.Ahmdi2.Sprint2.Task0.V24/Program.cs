using System;
using Tyuiu.Ahmadi2.Sprint2.Task0.V24.Lib;

namespace Tyuiu.Ahmadi2.Sprint2.Task0.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("*************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("*************************");

            int x = 135;
            int y = 755;
            Console.WriteLine($"X = {x}");
            Console.WriteLine($"Y = {y}");

            Console.WriteLine("*************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("*************************");

            bool[] res = ds.CompareOperations(x, y);

            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
    }
}