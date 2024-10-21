using Tyuiu.MiliukovLO.Sprint5.Task0.V27.Lib;

namespace Tyuiu.MiliukovLO.Sprint5.Task0.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            Assert.AreEqual("C:\\Users\\bibat\\AppData\\Local\\Temp\\tmphajmq2.tmp", ds.SaveToFileTextData(3));
        }
    }
}