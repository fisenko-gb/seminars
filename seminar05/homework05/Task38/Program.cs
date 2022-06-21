/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */
using System;
using static System.Console;
Clear();

int[] array = GetRandomArray(10, 1, 100);
WriteLine($"[{String.Join(", ", array)}] -> {Raznica(array)}");

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

int Raznica(int[] array)
{
    int min = array[0];
    int max = min;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }

        if (array[i] > max)
        {
            max = array[i];
        }
    }

    return max - min;
}