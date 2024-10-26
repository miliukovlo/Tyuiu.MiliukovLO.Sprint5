using System.Diagnostics;
using System.Net;
using Tyuiu.MiliukovLO.Sprint5.Task4.V28.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new();
        Console.Title = "Спринт #5 | Выполнил: Милюков Л. О. | ИИПб 24-2";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                                ");
        Console.WriteLine("* Тема: Чтение данных из текстового файла                                  ");
        Console.WriteLine("* Задание #4                                                               ");
        Console.WriteLine("* Вариант #28                                                              ");
        Console.WriteLine("* Выполнил: Милюков Леонид Олегович | ИИПб 24-2                            ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                 ");
        Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask4V0.txt (файл взять из архива ");
        Console.WriteLine("* согласно вашему варианту. Создать папку в ручную С:\\DataSprint5\\       ");
        Console.WriteLine("* и скопировать в неё файл) в котором есть вещественное значение. Прочитать");
        Console.WriteLine("* начение из файла и подставить вместо Х в формуле y = 3 * x^3 / sin(x)    ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
        Console.WriteLine("***************************************************************************");
        string path = "../../../../InPutDataFileTask4V28.txt";
        Console.WriteLine("*                                                                          ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
        Console.WriteLine("***************************************************************************");
        double result = ds.LoadFromDataFile(path);
        Console.WriteLine(result);
        Console.ReadKey();
    }
}