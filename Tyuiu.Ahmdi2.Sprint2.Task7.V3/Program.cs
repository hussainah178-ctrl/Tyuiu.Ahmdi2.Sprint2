using System;
using Tyuiu.Ahmadi2.Sprint2.Task7.V3.Lib;

namespace Tyuiu.Ahmadi2.Sprint2.Task7.V3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Ахмади | АСОиб 25-1";
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                       *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                                         *");
            Console.WriteLine("* Задание #3                                                                                      *");
            Console.WriteLine("* Вариант #3                                                                                      *");
            Console.WriteLine("* Выполнил: Ахмади |АСОиб 25-1                                                                    *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                        *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные                                   *");
            Console.WriteLine("* (вещественные значения) и вычисляет, находится ли точка с координатами                          *");
            Console.WriteLine("* X,Y в заштрихованной области.                                                                   *");
            Console.WriteLine("*                                                                                                 *");
            Console.WriteLine("*************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                *");
            Console.WriteLine("***************************************************************************************************");

            Console.Write("Введите координату X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координату Y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                      *");
            Console.WriteLine("***************************************************************************************************");

            bool result = CheckPointInShadedArea(x, y);
            Console.WriteLine($"Точка с координатами ({x}, {y}) {(result ? "находится" : "не находится")} в заштрихованной области");

            Console.ReadKey();
        }

        public static bool CheckPointInShadedArea(double x, double y)
        {
            // Проверка: точка должна быть ниже параболы y <= 1 - x^2
            bool belowParabola = y <= 1 - Math.Pow(x, 2);
            
            // Проверка: точка должна быть выше окружности x^2 + (y-1)^2 >= 1
            bool aboveCircle = Math.Pow(x, 2) + Math.Pow(y - 1, 2) >= 1;
            
            return belowParabola && aboveCircle;
        }
    }
}