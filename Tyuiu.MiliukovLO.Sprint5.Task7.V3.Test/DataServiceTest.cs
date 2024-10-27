using Tyuiu.MiliukovLO.Sprint5.Task7.V3.Lib;

namespace Tyuiu.MiliukovLO.Sprint5.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            string path = "../../../../InPutDataFileTask7V3.txt";
            Assert.AreEqual("some word vo", ds.LoadDataAndSave(path));
        }
    }
}