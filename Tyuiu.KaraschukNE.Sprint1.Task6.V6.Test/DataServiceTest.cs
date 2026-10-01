using Tyuiu.KaraschukNE.Sprint1.Task6.V6.Lib;
namespace Tyuiu.KaraschukNE.Sprint1.Task6.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string input = "Привет мир";
            string expected = "ривет ир";
            string result = ds.DeleteFirstLetter(input);
            Assert.AreEqual(expected, result);
        }
    }
}
