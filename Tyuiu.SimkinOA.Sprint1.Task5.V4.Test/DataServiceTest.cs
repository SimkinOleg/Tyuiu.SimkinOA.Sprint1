using Tyuiu.SimkinOA.Sprint1.Task5.V4.Lib;
namespace Tyuiu.SimkinOA.Sprint1.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 13257;
            double b = 0;
            var res = ds.Calculate(a, b);
            Assert.AreEqual(res, 3);
        }
    }
}
