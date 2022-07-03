/* **Задача 56:**Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
	
	Например, задан массив:
	
	1 4 7 2


    5 9 2 3


    8 4 2 4


    5 2 6 7


    Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */
using System;
using static System.Console;
using System.Linq;

Clear();

WriteLine("Введите размер матрицы через пробел: ");
string[] sizeS = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int m = int.Parse(sizeS[0]);
int n = int.Parse(sizeS[1]);
WriteLine("-----------------------------------------------------------------------------------");

int[,] mainArray = GetMatrix(m, n);
PrintMatrix(mainArray);
WriteLine("-----------------------------------------------------------------------------------");

int minI = MinSummArray(mainArray);
WriteLine("-----------------------------------------------------------------------------------");
WriteLine($"{minI + 1} строка");

int MinSummArray(int[,] array)
{
    int minI = -1;
    int summP = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int summa = 0;
        int j;
        for (j = 0; j < array.GetLength(1); j++)
        {
            summa += array[i, j];
        }

        if (minI == -1 || summa < summP)
        {
            minI = i;
            summP = summa;
        }

        WriteLine($"{i + 1} - сумма {summa}");

    }
    return minI;
}

int[,] GetMatrix(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, 11);
        }
    }
    return result;
}

void PrintMatrix(int[,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            Write($"{result[i, j]} \t ");
        }
        WriteLine();
    }
}




