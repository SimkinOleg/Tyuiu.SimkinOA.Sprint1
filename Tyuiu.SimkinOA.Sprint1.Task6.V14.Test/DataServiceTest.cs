using Tyuiu.SimkinOA.Sprint1.Task6.V14.Lib;
namespace Tyuiu.SimkinOA.Sprint1.Task6.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string a = "Абвгд";
            var res = ds.CheckLowerCaseRusLetters(a);
            Assert.AreEqual(res, true);
        }
    }
}
