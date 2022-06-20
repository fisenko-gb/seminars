/* **Задача 31:** Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.

Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
сумма отрицательных равна -20
 */
using System;
using static System.Console;
Clear();

int[] array = GetRandomArray(4, -5, 5);
WriteLine($"{String.Join(", ", array)}");
Write($"Сумма отрицательных: {GetNegotivSumm(array)}, Сумма положительных: {GetPozitivSumm(array)}");

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

int GetPozitivSumm(int[] array)
{
    int rezult = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            rezult += array[i];
        }
    }

    return rezult;
}

int GetNegotivSumm(int[] array)
{
    int rezult = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            rezult += array[i];
        }
    }

    return rezult;
}