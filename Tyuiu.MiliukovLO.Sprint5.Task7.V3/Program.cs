using Tyuiu.MiliukovLO.Sprint5.Task7.V3.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new();
        Console.Title = "Спринт #5 | Выполнил: Милюков Л. О. | ИИПб 24-2";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                                ");
        Console.WriteLine("* Тема: Чтение данных из текстового файла                                  ");
        Console.WriteLine("* Задание #6                                                               ");
        Console.WriteLine("* Вариант #30                                                              ");
        Console.WriteLine("* Выполнил: Милюков Леонид Олегович | ИИПб 24-2                            ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                 ");
        Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask6V30.txt в котором есть набор ");
        Console.WriteLine("*  символьных данных.Найти количество слов длиной восемь символов в        ");
        Console.WriteLine("* заданной строке.                                                         ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
        Console.WriteLine("***************************************************************************");
        string path = "../../../../InPutDataFileTask7V3.txt";
        Console.WriteLine("*                                                                          ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
        Console.WriteLine("***************************************************************************");
        string result = ds.LoadDataAndSave(path);
        Console.WriteLine(result);
        Console.ReadKey();
    }
}