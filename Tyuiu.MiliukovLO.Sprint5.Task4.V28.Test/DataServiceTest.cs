using Tyuiu.MiliukovLO.Sprint5.Task4.V28.Lib;

namespace Tyuiu.MiliukovLO.Sprint5.Task4.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            string path = "../../../../InPutDataFileTask4V28.txt";
            Assert.AreEqual(-253.43, ds.LoadFromDataFile(path));
        }
    }
}