using System;
using Tyuiu.Ahmdi2.Sprint2.Task5.V12.Lib;

namespace Tyuiu.Ahmdi2.Sprint2.Task5.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Sprint #2 | Executed by: Ahmadi | IIPb-23-1";
            Console.WriteLine("*************************");
            Console.WriteLine("* Sprint #2                                                               *");
            Console.WriteLine("* Topic: switch operator                                                  *");
            Console.WriteLine("* Task #5                                                                 *");
            Console.WriteLine("* Variant #12                                                             *");
            Console.WriteLine("* Executed by: Ahmadi | IIPb-23-1                                         *");
            Console.WriteLine("*************************");
            Console.WriteLine("* Condition:                                                              *");
            Console.WriteLine("* Write a program that uses the switch operator to calculate the required *");
            Console.WriteLine("* value and return the result. The date of a certain day is characterized *");
            Console.WriteLine("* by three natural numbers: g (year), m (month number) and n (day).       *");
            Console.WriteLine("* Determine the date of the previous day from the given g, n and m.       *");
            Console.WriteLine("* The given year is a leap year.                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*************************");
            Console.WriteLine("* INITIAL DATA:                                                           *");
            Console.WriteLine("*************************");

            Console.WriteLine("Enter the year (g):");
            int g = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the month (m):");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the day (n):");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*************************");
            Console.WriteLine("* RESULT:                                                                 *");
            Console.WriteLine("*************************");

            double result = ds.FindDateOfPreviousDay(g, m, n);
            Console.WriteLine($"Date of the previous day: {result}");

            Console.ReadKey();
        }
    }
}