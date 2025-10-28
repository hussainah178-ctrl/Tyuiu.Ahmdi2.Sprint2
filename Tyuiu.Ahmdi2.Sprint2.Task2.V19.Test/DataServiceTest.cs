using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Ahmadi2.Sprint2.Task2.V19.Lib;

namespace Tyuiu.Ahmadi2.Sprint2.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            // Точка внутри заштрихованной области
            Assert.AreEqual(true, ds.CheckDotInShadedArea(5, 5));
            Assert.AreEqual(true, ds.CheckDotInShadedArea(8, 8));
            Assert.AreEqual(true, ds.CheckDotInShadedArea(11, 11));

            // Точка вне заштрихованной области
            Assert.AreEqual(false, ds.CheckDotInShadedArea(1, 1));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(15, 15));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(5, 15));
        }
    }
}