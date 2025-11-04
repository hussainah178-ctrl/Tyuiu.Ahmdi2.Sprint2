using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Ahmadi2.Sprint2.Task7.V3.Lib;

namespace Tyuiu.Ahmadi2.Sprint2.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            // Точка в заштрихованной области
            Assert.IsTrue(ds.CheckDotInShadedArea(0, 0.5));

            // Точка вне заштрихованной области 
            Assert.IsFalse(ds.CheckDotInShadedArea(0, 1.5));
        } 
    }
}