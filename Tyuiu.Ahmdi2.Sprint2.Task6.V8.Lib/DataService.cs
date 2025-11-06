using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.Ahmadi2.Sprint2.Task6.V8.Lib
{
    public class DataService : ISprint2Task6V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            if (n < 1 || n > 12)
                throw new ArgumentException("Номер месяца должен быть от 1 до 12");

            if (m < 1 || m > 31)
                throw new ArgumentException("Число должно быть от 1 до 31");

            // Проверка на 1 января
            if (n == 1 && m == 1)
                throw new ArgumentException("Дата не должна быть 1 января");

            int prevDay, prevMonth;

            if (m > 1)
            {
                // Если день не первый в месяце
                prevDay = m - 1;
                prevMonth = n;
            }
            else
            {
                // Если день первый, переходим к предыдущему месяцу
                prevMonth = n - 1;

                // Используем сокращенную форму switch для определения дней в месяце
                prevDay = prevMonth switch
                {
                    1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
                    4 or 6 or 9 or 11 => 30,
                    2 => 28, // Предполагаем невисокосный год
                    _ => 31 // Для месяца 0 (декабрь предыдущего года)
                };

            }

            return $"{prevDay}.{prevMonth}";
        }
    }
}