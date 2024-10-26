using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MiliukovLO.Sprint5.Task4.V28.Lib
{
    public class DataService : ISprint5Task4V28
    {
        public double LoadFromDataFile(string path)
        {
            double number = 0;
            string data = File.ReadAllText(path);
            number = double.Parse(data);
            return Math.Round((3 * Math.Pow(number, 3)) / Math.Sin(number),3);
        }
    }
}
