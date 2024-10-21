using Tyuiu.MiliukovLO.Sprint5.Task0.V27.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new();
        Console.Title = "Спринт #5 | Выполнил: Милюков Л. О. | ИИПб 24-2";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                                ");
        Console.WriteLine("* Тема: Запись данных в текстовый файл                                     ");
        Console.WriteLine("* Задание #0                                                               ");
        Console.WriteLine("* Вариант #27                                                              ");
        Console.WriteLine("* Выполнил: Милюков Леонид Олегович | ИИПб 24-2                            ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                 ");
        Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить в   ");
        Console.WriteLine("* екстовый файл OutPutFileTask0.txt и вывести на консоль. Округлить до трёх");
        Console.WriteLine("* знаков после запятой.                                                    ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
        Console.WriteLine("***************************************************************************");
        int x = 3;
        Console.WriteLine("*                                                                          ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
        Console.WriteLine("***************************************************************************");
        string result = ds.SaveToFileTextData(x);
        Console.WriteLine(result);
        Console.ReadKey();
    }
}