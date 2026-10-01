using Tyuiu.KaraschukNE.Sprint1.Task4.V20.Lib;
namespace Tyuiu.KaraschukNE.Sprint1.Task4.V20.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void VoidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
