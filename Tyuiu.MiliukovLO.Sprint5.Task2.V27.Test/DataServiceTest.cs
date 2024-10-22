using Tyuiu.MiliukovLO.Sprint5.Task2.V27.Lib;

namespace Tyuiu.MiliukovLO.Sprint5.Task2.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            int[,] matrix = { { 1, 4, 3 }, { 1, 1, 4 }, { 4, 3, 8 } };
            Assert.AreEqual("C:\\Users\\bibat\\AppData\\Local\\Temp\\tmphajmq2.tmp", ds.SaveToFileTextData(matrix));
        }
    }
}