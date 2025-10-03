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
            int a = 13257;
            var res = ds.SecondsToHours(a);
            Assert.AreEqual(res, 3);
        }
    }
}
