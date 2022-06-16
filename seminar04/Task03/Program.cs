/* **Задача 30:**

Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

[1,0,1,1,0,1,0,0] */
using System;
using static System.Console;
Clear();

//int[] array = { 8, 4, 3, 2, 6, 6 };
int[] ar = new int[7];
Fill(ar);

void Fill(int[] ar)
{

    for (int i = 0; i < ar.Length; i++)
    {
        int number = new Random().Next(0, 2);
        ar[i] = number;
        Write($"{ar[i]}, ");
    }

}