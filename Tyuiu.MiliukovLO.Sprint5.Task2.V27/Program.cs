﻿using Tyuiu.MiliukovLO.Sprint5.Task2.V27.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new();
        Console.Title = "Спринт #5 | Выполнил: Милюков Л. О. | ИИПб 24-2";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                                ");
        Console.WriteLine("* Тема: Запись структурированных данных в текстовый файл                   ");
        Console.WriteLine("* Задание #2                                                               ");
        Console.WriteLine("* Вариант #27                                                              ");
        Console.WriteLine("* Выполнил: Милюков Леонид Олегович | ИИПб 24-2                            ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                 ");
        Console.WriteLine("* Дана функция, F(x)= ((3x-1,5)/(sin(x)-3+x)) + 2 (произвести табулирование");
        Console.WriteLine("*  f(x) на заданном диапозоне [-5;5] с шагом 1. произвести проверку        ");
        Console.WriteLine("* деления на ноль. при делении на ноль вернуть значение 0. Результат       ");
        Console.WriteLine("* сохранить в текстовый файл                                               ");
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