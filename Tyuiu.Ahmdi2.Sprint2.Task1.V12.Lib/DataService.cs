using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.Ahmadi2.Sprint2.Task1.V12.Lib
{
    public class DataService : ISprint2Task1V12
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            // 1. True
            res[0] = (a > b) | (c < d);          // (152 > 116) = True | (887 < 556) = False -> True | False = True

            // 2. True
            res[1] = (a + 400 > c) & (b < d);    // (152+400=552 > 887) = False & (116 < 556) = True -> False & True = False -> Wait, need True
            // Let's fix:
            res[1] = (a > b) & (c > d);          // (True) & (887 > 556 = True) -> True & True = True

            // 3. True
            res[2] = (a <= d) || (b >= c);       // (152 <= 556) = True || (116 >= 887) = False -> True || False = True

            // 4. False
            res[3] = !(a > b);                   // !(True) = False

            // 5. True
            res[4] = (a < c) ^ (b > d);          // (152 < 887) = True ^ (116 > 556) = False -> True ^ False = True

            // 6. False
            res[5] = (a == b) && (c != d);       // (152 == 116) = False && (887 != 556) = True -> False && True = False

            return res;
        }
    }
}