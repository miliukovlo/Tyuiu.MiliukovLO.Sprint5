using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MiliukovLO.Sprint5.Task6.V30.Lib
{
    public class DataService : ISprint5Task6V30
    {
        public int LoadFromDataFile(string path)
        {
            string content = File.ReadAllText(path);
            string[] strings = content.Split(new[] { ' ' });
            int count = 0;
            foreach (string word in strings) {
                if (word.Length == 8) { count++; }
            }
            return count;
        }
    }
}
