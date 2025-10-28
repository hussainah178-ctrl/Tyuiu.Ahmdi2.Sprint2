using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Ahmadi2.Sprint2.Task4.V4.Lib;

namespace Tyuiu.Ahmadi2.Sprint2.Task4.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateConditionTrue()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 5;
            // x + 2 = 3 < 5 = true -> sin(1) + 2*5
            double wait = 10.841; // sin(1) ≈ 0.841 + 10 = 10.841
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateConditionFalse()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 1;
            // x + 2 = 7 > 1 = false -> cos(1) + 2*5*1
            double wait = 10.540; // cos(1) ≈ 0.540 + 10 = 10.540
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}