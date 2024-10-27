using Tyuiu.MiliukovLO.Sprint5.Task6.V30.Lib;

namespace Tyuiu.MiliukovLO.Sprint5.Task6.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            string path = "../../../../InPutDataFileTask6V30.txt";
            Assert.AreEqual(2, ds.LoadFromDataFile(path));
        }
    }
}