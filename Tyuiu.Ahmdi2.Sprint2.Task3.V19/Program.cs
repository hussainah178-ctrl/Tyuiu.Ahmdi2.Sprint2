using System;
using Tyuiu.Ahmadi2.Sprint2.Task3.V19.Lib;

namespace Tyuiu.Ahmadi2.Sprint2.Task3.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Sprint #2 | Executed by: Ahmadi | IIPb-23-1";
            Console.WriteLine("*************************");
            Console.WriteLine("* Sprint #2                                                               *");
            Console.WriteLine("* Topic: Nested if-else operators                                         *");
            Console.WriteLine("* Task #3                                                                 *");
            Console.WriteLine("* Variant #19                                                             *");
            Console.WriteLine("* Executed by: Ahmadi | IIPb-23-1                                         *");
            Console.WriteLine("*************************");
            Console.WriteLine("* Condition:                                                              *");
            Console.WriteLine("* Write a program that calculates the required value of the function Y    *");
            Console.WriteLine("* using nested if-else operators, where the user enters the value of the  *");
            Console.WriteLine("* variable X from the keyboard. Round the result to three decimal places. *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*************************");
            Console.WriteLine("* INITIAL DATA:                                                           *");
            Console.WriteLine("*************************");

            Console.WriteLine("Enter the value of variable X:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*************************");
            Console.WriteLine("* RESULT:                                                                 *");
            Console.WriteLine("*************************");

            double result = ds.Calculate(x);
            Console.WriteLine($"Function value Y = {result}");

            Console.ReadKey();
        }
    }
}