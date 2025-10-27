using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Ahmadi2.Sprint2.Task1.V12.Lib;

namespace Tyuiu.Ahmadi2.Sprint2.Task1.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 152;
            int b = 116;
            int c = 887;
            int d = 556;
            bool[] wait = new bool[] { true, true, true, false, true, false };
            bool[] res = ds.GetLogicOperations(a, b, c, d);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}