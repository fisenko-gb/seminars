/* **Задача 29:**Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33-> [6, 1, 33] */
using System;
using static System.Console;

Clear();

PrintArray(GenerateArray(8, 1, 25));

int[] GenerateArray(int size = 10, int minValue = 0, int maxValue = 1)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);
    }

    return array;
}

void PrintArray(int[] array)
{
    Write($"{String.Join(", ", array)}");

    WriteLine($"-> [{String.Join(", ", array)}]");
}