using Tyuiu.SimkinOA.Sprint1.Task4.V25.Lib;
namespace Tyuiu.SimkinOA.Sprint1.Task4.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 0;
            var res = ds.Calculate(a);
            Assert.AreEqual(res,0);
        }
    }
}
