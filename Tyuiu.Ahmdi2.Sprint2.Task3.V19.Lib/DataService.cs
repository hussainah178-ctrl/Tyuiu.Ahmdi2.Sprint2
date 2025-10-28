using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.Ahmadi2.Sprint2.Task3.V19.Lib
{
    public class DataService : ISprint2Task3V19
    {
        public double Calculate(double x)
        {
            double y;

            if (x > 1)
            {
                y = Math.Pow(x, 2) + Math.Pow((x + 1) / (x - 1), x);
            }
            else if (x == 0)
            {
                y = Math.Pow(x, 2) + Math.Cos(Math.Pow(x, 2)) + 13;
            }
            else if (x < -23)
            {
                y = x + 10 * x - (1 / x);
            }
            else if (x < 2)
            {
                y = Math.Pow(x, 2) + Math.Sin(Math.Pow(x, 2)) + 9;
            }
            else
            {
                y = Math.Pow(1 + 1 / Math.Pow(x, 2), x);
            }

            return Math.Round(y, 3);
        }
    }
}