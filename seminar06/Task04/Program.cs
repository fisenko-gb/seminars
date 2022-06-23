//Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
using System;
using static System.Console;

Clear();

int[] array = GetRandomArray(4, -5, 5);
WriteLine($"{String.Join(", ", array)}");
WriteLine($"{String.Join(", ", GetCopyArray(array))}");

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

int[] GetCopyArray(int[] array)
{
    int[] result = new int[array.Length];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = array[i];
    }

    return result;
}