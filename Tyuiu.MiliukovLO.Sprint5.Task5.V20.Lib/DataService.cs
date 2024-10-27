using System;
using System.Collections.Generic;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MiliukovLO.Sprint5.Task5.V20.Lib
{
    public class DataService : ISprint5Task5V20
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            string[] strings = text.Split(',');
            List<int> validNumbers = new List<int>();

            foreach (string str in strings)
            {
                if (int.TryParse(str.Trim(), out int number))
                {
                   validNumbers.Add(number);
                }
            }

            double sum = 0;
            foreach (int number in validNumbers)
            {
                sum += number;
            }

            double average = sum / validNumbers.Count;
            return Math.Round(average, 3);
        }
    }
}
