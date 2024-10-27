using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MiliukovLO.Sprint5.Task5.V20.Lib
{
    public class DataService : ISprint5Task5V20
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            string[] strings = text.Split(',');
            List<string> data = new List<string>();
            double sum = 0;
            foreach (string str in strings)
            {
                if (int.TryParse(str.Trim(), out int number))
                {
                    sum += number;
                }
            }
            return Math.Round(sum/strings.Length,3);
        }
    }
}
