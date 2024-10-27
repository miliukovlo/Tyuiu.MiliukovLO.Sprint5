using Tyuiu.MiliukovLO.Sprint5.Task5.V20.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new();
        Console.Title = "Спринт #5 | Выполнил: Милюков Л. О. | ИИПб 24-2";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                                ");
        Console.WriteLine("* Тема: Чтение данных из текстового файла                                  ");
        Console.WriteLine("* Задание #5                                                               ");
        Console.WriteLine("* Вариант #20                                                              ");
        Console.WriteLine("* Выполнил: Милюков Леонид Олегович | ИИПб 24-2                            ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                 ");
        Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask5V20.txt Создать папку в ручну");
        Console.WriteLine("*  С:\\DataSprint5\\ и скопировать в неё файл) в котором есть набор        ");
        Console.WriteLine("* значений. Найти среднее значение всех целых чисел в файле, которые       ");
        Console.WriteLine("* находятся в промежутке от -10 до 10. Полученный результат вывести на     ");
        Console.WriteLine("* консоль. У вещественных значений округлить до трёх знаков после запятой. ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
        Console.WriteLine("***************************************************************************");
        string path = "../../../../InPutDataFileTask5V20.txt";
        Console.WriteLine("*                                                                          ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
        Console.WriteLine("***************************************************************************");
        double result = ds.LoadFromDataFile(path);
        Console.WriteLine(result);
        Console.ReadKey();
    }
}