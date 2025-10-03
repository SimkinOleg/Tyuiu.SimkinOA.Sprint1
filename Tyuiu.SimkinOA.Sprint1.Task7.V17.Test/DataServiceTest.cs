using Tyuiu.SimkinOA.Sprint1.Task7.V17.Lib;
namespace Tyuiu.SimkinOA.Sprint1.Task7.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 0;
            double b = 180;
            
            double res = ds.Calculate(a,b);
            Assert.AreEqual(res, 2.847);
        }
    }
}
