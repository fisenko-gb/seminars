/* **Задача 50.** Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1 7 -> такого числа в массиве нет */
using System;
using static System.Console;

Clear();
Write("Введите координаты в массиве через пробел: ");
string[] sizeS = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int rows = int.Parse(sizeS[0]);
int columns = int.Parse(sizeS[1]);

int[,] ar = GetRandomArray(5, 5);
PrintArray(ar);

if (rows > ar.GetLength(0) || columns > ar.GetLength(1))
{
    Write($"{rows} {columns} -> такого числа в массиве нет");
}else
{
    Write($"{rows} {columns} -> {ar[rows-1, columns-1]}");
}


int[,] GetRandomArray(int row, int columm)
{
    int[,] rezult = new int[row, columm];

    for (int i = 0; i < rezult.GetLength(0); i++)
    {
        for (int j = 0; j < rezult.GetLength(1); j++)
        {
            
            rezult[i, j] = new Random().Next(1,5);
            
        }
    }
    return rezult;
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
     WriteLine();
}
