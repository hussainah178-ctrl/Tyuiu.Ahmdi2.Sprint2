using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.Ahmadi2.Sprint2.Task0.V24.Lib
{
    public class DataService : ISprint2Task0V24
    {
        public bool[] CompareOperations(int x, int y)
        {
            bool[] results = new bool[6];

            // Операции сравнения, не нарушая последовательность
            results[0] = x + 620 == y;           // 135 + 620 = 755 == 755 -> True
            results[1] = x != y - 620;           // 135 != 755 - 620 = 135? -> 135 != 135? -> False -> Wait, need True
            // Let's recalc carefully to match (True, True, False, False, True, True)
            // We can design step by step:

            // 1. True
            results[0] = x + 620 == y;           // 135 + 620 = 755 == 755 -> True

            // 2. True
            results[1] = y - 620 == x;           // 755 - 620 = 135 == 135 -> True

            // 3. False
            results[2] = x > y;                  // 135 > 755 -> False

            // 4. False
            results[3] = x >= y;                 // 135 >= 755 -> False

            // 5. True
            results[4] = x < y;                  // 135 < 755 -> True

            // 6. True
            results[5] = x <= y;                 // 135 <= 755 -> True

            return results;
        }

        public bool[] GetCompareOperations(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}