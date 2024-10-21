using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MiliukovLO.Sprint5.Task0.V27.Lib
{
    public class DataService : ISprint5Task0V27
    {
        public string SaveToFileTextData(int x)
        {
            double result = Math.Pow(x - 1, 3 * x + 1);

            double roundedResult = Math.Round(result, 3);

            string tempFilePath = Path.GetTempFileName();

            File.WriteAllText(tempFilePath, roundedResult.ToString());

            return tempFilePath;
        }
    }
}
