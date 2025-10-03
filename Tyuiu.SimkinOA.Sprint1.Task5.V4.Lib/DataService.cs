using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.SimkinOA.Sprint1.Task5.V4.Lib
{
    public class DataService : ISprint1Task1V4

    {
        public double Calculate(double x, double y)
        {
            
            y = x / 3600;
            return Convert.ToInt32(x / 3600);
        }
    }
}
