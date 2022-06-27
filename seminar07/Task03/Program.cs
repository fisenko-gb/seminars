using System;
using static System.Console;
Clear();
Write("Введите число строк массива  ");
int m = int.Parse(ReadLine());
Write("Введите число столбцов массива  ");
int n = int.Parse(ReadLine());
int[,] arrayi = FillArrayMPLUSN(m, n);
PrintArray(arrayi);
WriteLine();
arrayi = GetCHET(arrayi);
PrintArray(arrayi);


int[,] GetCHET(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i += 2)
    {
        for (int j = 0; j < array.GetLength(1); j += 2)
        {
            array[i, j] = array[i, j] * array[i, j];
        }
    }
    return array;
}

int[,] FillArrayMPLUSN(int rows, int len)
{
    int[,] array = new int[rows, len];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($" {array[i, j]}");
        }
        WriteLine();
    }
}

