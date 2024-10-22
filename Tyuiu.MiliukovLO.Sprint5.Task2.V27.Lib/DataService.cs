﻿using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MiliukovLO.Sprint5.Task2.V27.Lib
{
    public class DataService : ISprint5Task2V27
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string tempFilePath = Path.GetTempFileName();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int valueToWrite = matrix[i, j];

                    if ((i + j) % 2 != 0)
                    {
                        valueToWrite = 0;
                    }

                    File.AppendAllText(tempFilePath, $"{valueToWrite}");

                    if (j < matrix.GetLength(1) - 1)
                    {
                        File.AppendAllText(tempFilePath, ";");
                    }
                }
                File.AppendAllText(tempFilePath, "\n");
            }

            return tempFilePath;
        }
    }
}
