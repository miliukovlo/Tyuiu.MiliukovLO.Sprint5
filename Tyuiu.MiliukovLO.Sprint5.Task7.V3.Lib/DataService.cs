using System;
using System.IO;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MiliukovLO.Sprint5.Task7.V3.Lib
{
    public class DataService : ISprint5Task7V3
    {
        public string LoadDataAndSave(string path)
        {
            string content = File.ReadAllText(path);

            string result = Regex.Replace(content, "[а-яА-ЯёЁ]", "");

            string temp = Path.GetTempPath();
            string outPath = Path.Combine(temp, "OutPutDataFileTask7V3.txt");

            File.WriteAllText(outPath, result);

            return result;
        }
    }
}
