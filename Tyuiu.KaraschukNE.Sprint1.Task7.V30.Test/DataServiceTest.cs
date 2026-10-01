using Tyuiu.KaraschukNE.Sprint1.Task7.V30.Lib;
namespace Tyuiu.KaraschukNE.Sprint1.Task7.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void VoidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double expected = 5.612;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(expected, res);

        }
    }
}
