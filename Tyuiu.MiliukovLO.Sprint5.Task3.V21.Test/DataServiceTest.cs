using Tyuiu.MiliukovLO.Sprint5.Task3.V21.Lib;

namespace Tyuiu.MiliukovLO.Sprint5.Task3.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            int test = 3;
            Assert.AreEqual("C:\\Users\\bibat\\AppData\\Local\\Temp\\tmphajmq2.tmp", ds.SaveToFileTextData(test));
        }
    }
}