/* **Задача 33:** Задайте массив. Напишите программу, которая определяет, присутствует ли заданное 
число в массиве.

4; массив [6, 7, 19, 345, 3] -> нет

3; массив [6, 7, 19, 345, 3] -> да */

using System;
using static System.Console;
Clear();

Write("Ведите число: ");
int number = int.Parse(ReadLine());
int[] array = GetRandomArray(5, -2, 5);
WriteLine($"{number}; массив [{String.Join(", ", array)}] -> {FindNumber(array, number)}");

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

string FindNumber(int[] array, int numbers)
{
    string flag = "нет";

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == numbers)
        {
            flag = "да";
            break;
        }
    }
    return flag;
}