/* **Задача 32:** Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

[-4, -8, 8, 2] -> [4, 8, -8, -2] */

using System;
using static System.Console;
Clear();

int[] array = GetRandomArray(5, -5, 5);
Write($"[{String.Join(", ", array)}] ->");
GetReverse(array);
Write($"[{String.Join(", ", array)}]");

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

void GetReverse(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
       
            array[i] *= -1;
        
    }

}