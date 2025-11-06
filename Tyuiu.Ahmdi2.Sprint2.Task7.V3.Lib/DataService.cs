using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.Ahmadi2.Sprint2.Task7.V3.Lib
{
    public class DataService :ISprint2Task7V3
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if (((1-Math.Pow(x, 2)>=y) && (Math.Pow(x, 2) + Math.Pow((y - 1), 2)<=1)) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
            
            
        }
    }
}
//bool belowParabola = y <= 1 - System.Math.Pow(x, 2);
//bool aboveCircle = System.Math.Pow(x, 2) + System.Math.Pow(y - 1, 2) >= 1;

//return belowParabola && aboveCircle;