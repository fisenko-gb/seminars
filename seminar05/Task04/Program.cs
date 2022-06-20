/* **Задача 35:** Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

*Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*

[5, 18, 123, 6, 2] -> 1

[1, 2, 3, 6, 2] -> 0

[10, 11, 12, 13, 14] -> 5 */

using System;
using static System.Console;
Clear();

Write("Введите размер массива: ");
int size = int.Parse(ReadLine());
int[] array = fillArray(size, -10, 10);

Write("Массив: ");
printArray(array);
WriteLine();

printArray(multiplicationPars(array));

int[] multiplicationPars(int[] arrayTemp) // произведение пар 
{
    int[] result = new int[arrayTemp.Length/2];

    for (int i = 0; i < arrayTemp.Length/2; i++)
    {
        result[i] = arrayTemp[i] * arrayTemp[(arrayTemp.Length-1)-i];
    }
    return result;
}

int[] fillArray(int size, int min, int max) // Заполнение массива
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
       array[i] = new Random().Next(min, max +1);
    }
    return array;
}

void printArray(int[] array) // Печать массива
 {
    Write("[");
     for (int i = 0; i < array.Length; i++)
     {
        Write(array[i]);
        Write(i < array.Length-1 ? ", " : "");
     }
     Write("]");
 }