using Tyuiu.Ahmdi2.Sprint2.Task6.V8.Lib;
namespace Tyuiu.Ahmadi2.Sprint2.Task6.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Ахмади | АСОиб 25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #8                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Ахмади | АСОиб 25-1                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дата некоторого дня характеризуется двумя натуральными числами:         *");
            Console.WriteLine("* n (порядковый номер месяца) и m (число). По заданным n и m определить   *");
            Console.WriteLine("* дату предыдущего дня (принять, что n и m не характеризуют 1 января).    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите номер месяца (1-12): ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string result = ds.FindDateOfPreviousDay(n, m);
            Console.WriteLine($"Предыдущая дата: {result}");

            Console.ReadKey();
        }

        public static string GetPreviousDate(int month, int day)
        {
            int prevDay, prevMonth;

            if (day > 1)
            {
                // Если день не первый в месяце, просто уменьшаем день
                prevDay = day - 1;
                prevMonth = month;
            }
            else
            {
                // Если день первый, переходим к предыдущему месяцу
                prevMonth = month - 1;

                // Определяем количество дней в предыдущем месяце
                prevDay = prevMonth switch
                {
                    1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
                    4 or 6 or 9 or 11 => 30,
                    2 => 28, // Невисокосный год
                    _ => 0
                };
            }

            return $"{prevDay}.{prevMonth}";
        }
    }
}