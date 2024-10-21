using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MiliukovLO.Sprint5.Task1.V27.Lib
{
    public class DataService : ISprint5Task1V27
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string tempFilePath = Path.GetTempFileName();
            double start = startValue, end = stopValue, step = 1;
            for (double x = start; x <= end; x += step)
            {
                double result = ((3 * x - 1.5) /( Math.Sin(x) - 3 + x)) + 2;
                if (double.IsNaN(result) || double.IsInfinity(result))
                {
                    result = 0;
                }
                result = Math.Round(result,2);
                File.AppendAllText(tempFilePath, $"{result}\n");
                Console.WriteLine($"{result}");
            }
            return tempFilePath;
        }
    }
}
