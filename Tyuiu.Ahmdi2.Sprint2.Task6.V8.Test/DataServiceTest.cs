using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Ahmadi2.Sprint2.Task6.V8.Lib;

namespace Tyuiu.Ahmadi2.Sprint2.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindPreviousDate()
        {
            DataService ds = new DataService();

            // Тест 1: Обычный случай (не первое число)
            Assert.AreEqual("15.3", ds.FindPreviousDate(3, 16));

            // Тест 2: Первое число месяца (переход к предыдущему месяцу)
            Assert.AreEqual("31.3", ds.FindPreviousDate(4, 1));

            // Тест 3: Первое число марта (переход к февралю)
            Assert.AreEqual("28.2", ds.FindPreviousDate(3, 1));

            // Тест 4: Первое число января (должна быть ошибка по условию)
            // Assert.ThrowsException<ArgumentException>(() => ds.FindPreviousDate(1, 1));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidDateTest()
        {
            DataService ds = new DataService();
            ds.FindPreviousDate(1, 1); // 1 января - должно вызывать исключение
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidMonthTest()
        {
            DataService ds = new DataService();
            ds.FindPreviousDate(13, 15); // Неверный месяц
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidDayTest()
        {
            DataService ds = new DataService();
            ds.FindPreviousDate(5, 32); // Неверный день
        }
    }
}