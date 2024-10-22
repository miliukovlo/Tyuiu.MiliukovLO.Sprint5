using Tyuiu.MiliukovLO.Sprint5.Task3.V21.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new();
        Console.Title = "Спринт #5 | Выполнил: Милюков Л. О. | ИИПб 24-2";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                                ");
        Console.WriteLine("* Тема: Запись структурированных данных в текстовый файл                   ");
        Console.WriteLine("* Задание #3                                                               ");
        Console.WriteLine("* Вариант #21                                                              ");
        Console.WriteLine("* Выполнил: Милюков Леонид Олегович | ИИПб 24-2                            ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                 ");
        Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить в   ");
        Console.WriteLine("* инарный файл OutPutFileTask3.bin и вывести на консоль. Округлить до трёх ");
        Console.WriteLine("* знаков после запятой.                                                    ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
        Console.WriteLine("***************************************************************************");
        int[,] matrix = { { 1, 4, 3 }, { 1, 1, 4 }, { 4, 3, 8 } };
        Console.WriteLine("*                                                                          ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
        Console.WriteLine("***************************************************************************");
        string result = ds.SaveToFileTextData(matrix);
        Console.WriteLine(result);
        Console.ReadKey();
    }
}