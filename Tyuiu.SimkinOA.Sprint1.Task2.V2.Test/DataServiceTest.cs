using Tyuiu.SimkinOA.Sprint1.Task2.V2.Lib;
namespace Tyuiu.SimkinOA.Sprint1.Task2.V2.Test

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression() 
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.ConvertAngleToRad(x);
            Assert.AreEqual(2,0.035);

        }
    }
}
