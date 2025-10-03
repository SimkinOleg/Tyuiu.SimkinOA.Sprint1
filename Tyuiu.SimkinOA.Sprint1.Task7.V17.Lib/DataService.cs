using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.SimkinOA.Sprint1.Task7.V17.Lib
{
    public class DataService : ISprint1Task7V17
    {
        public double Calculate(double x, double y)
        {
            double chislitel, znamematel, podkoren, step;
            step = Math.Pow(x, 2);
            podkoren = Math.Sin(Math.Sqrt(step+1));
            chislitel = 1+ podkoren;
            znamematel = Math.Cos(12*y-4);
            return Math.Round(chislitel/znamematel,3);
            
        }
    }
}
