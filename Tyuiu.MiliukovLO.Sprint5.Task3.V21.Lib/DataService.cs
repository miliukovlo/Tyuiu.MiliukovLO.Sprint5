using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.MiliukovLO.Sprint5.Task3.V21.Lib
{
    public class DataService : ISprint5Task3V21
    {
        public string SaveToFileTextData(int x)
        {
            string tempFile = Path.GetTempFileName();
            double res = (Math.Pow(x,2)+1)/Math.Sqrt(4 * Math.Pow(x,2) - 3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(tempFile, FileMode.Append)))
            {
                writer.Write(res);
            }
            return tempFile;
        }
    }
}
