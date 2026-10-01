using Tyuiu.KaraschukNE.Sprint1.Task5.V7.Lib;
namespace Tyuiu.KaraschukNE.Sprint1.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void VoidExpression()
        {
            DataService ds = new DataService();
            double f = 30;
            var res = ds.AngleToHoursMinutes(f);
            Assert.AreEqual(1, res);
        }
    }
}
