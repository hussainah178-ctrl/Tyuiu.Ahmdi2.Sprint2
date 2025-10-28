using System;
using Tyuiu.Ahmadi2.Sprint2.Task4.V4.Lib;

namespace Tyuiu.Ahmadi2.Sprint2.Task4.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Sprint #2 | Executed by: Ahmadi | IIPb-23-1";
            Console.WriteLine("*************************");
            Console.WriteLine("* Sprint #2                                                               *");
            Console.WriteLine("* Topic: Ternary operator                                                 *");
            Console.WriteLine("* Task #4                                                                 *");
            Console.WriteLine("* Variant #4                                                              *");
            Console.WriteLine("* Executed by: Ahmadi | IIPb-23-1                                         *");
            Console.WriteLine("*************************");
            Console.WriteLine("* Condition:                                                              *");
            Console.WriteLine("* Write a program that calculates the required value using the ternary    *");
            Console.WriteLine("* operator, where the user enters the values of variables x, y from the  *");
            Console.WriteLine("* keyboard. If x + 2 < y, then z = sin(x) + 2y, otherwise cos(y) + 2xy.  *");
            Console.WriteLine("* Round the answer to 3 decimal places.                                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*************************");
            Console.WriteLine("* INITIAL DATA:                                                           *");
            Console.WriteLine("*************************");

            Console.WriteLine("Enter the value of variable X:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of variable Y:");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*************************");
            Console.WriteLine("* RESULT:                                                                 *");
            Console.WriteLine("*************************");

            double result = ds.Calculate(x, y);
            Console.WriteLine($"Value Z = {result}");

            Console.ReadKey();
        }
    }
}