using Tyuiu.MiliukovLO.Sprint5.Task5.V20.Lib;

namespace Tyuiu.MiliukovLO.Sprint5.Task5.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            string path = "../../../../InPutDataFileTask5V20.txt";
            Assert.AreEqual(5.5, ds.LoadFromDataFile(path));
        }
    }
}