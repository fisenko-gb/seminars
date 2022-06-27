/* **Задача 48:**Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m + n.Выведите полученный массив на экран.

m = 3, n = 4.

0 1 2 3

1 2 3 4

2 3 4 5 */

using System;
using static System.Console;

Clear();

Write("Введите размер матрицы через пробел: ");
string[] sizeS = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
WriteLine();
int m = int.Parse(sizeS[0]);
int n = int.Parse(sizeS[1]);
PrintArray(GetArray(m, n));

int[,] GetArray(int row, int column)
{
    int[,] result = new int[row, column];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = i + j;
        }
    }
    return result;
}

void PrintArray(int[,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            Write($"{result[i, j]} ");
        }
        WriteLine();
    }
}
