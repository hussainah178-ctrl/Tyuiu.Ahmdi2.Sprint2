using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.Ahmadi2.Sprint2.Task2.V19.Lib
{
    public class DataService :ISprint2Task2V19
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            // منطقه سایه‌دار: مربع از (5,5) تا (11,11)
            bool inShadedArea = (x >= 5 && x <= 11) && (y >= 5 && y <= 11);

            return inShadedArea;
        }
    }
}