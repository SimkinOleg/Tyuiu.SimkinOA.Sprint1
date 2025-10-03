using tyuiu.cources.programming.interfaces.Sprint1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Tyuiu.SimkinOA.Sprint1.Task2.V2.Lib
{
    public class DataService : ISprint1Task2V2
    {
        public double ConvertAngleToRad(int value)
        {
            double res = 3.1415926535 / 180 * value;
            return Math.Round(res,3);
        }
    }
}
