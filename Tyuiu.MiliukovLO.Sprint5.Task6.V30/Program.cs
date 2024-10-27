using Tyuiu.MiliukovLO.Sprint5.Task6.V30.Lib;

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
        string path = "../../../../InPutDataFileTask6V30.txt";
        Console.WriteLine("*                                                                          ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
        Console.WriteLine("***************************************************************************");
        int result = ds.LoadFromDataFile(path);
        Console.WriteLine(result);
        Console.ReadKey();
    }
}