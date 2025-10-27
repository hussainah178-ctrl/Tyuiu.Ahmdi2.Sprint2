using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Ahmadi2.Sprint2.Task0.V24.Lib;

namespace Tyuiu.Ahmadi2.Sprint2.Task0.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCompareOperations()
        {
            DataService ds = new DataService();
            int x = 135;
            int y = 755;
            bool[] wait = new bool[] { true, true, false, false, true, true };
            bool[] res = ds.CompareOperations(x, y);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}