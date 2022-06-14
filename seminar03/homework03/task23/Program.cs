/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */
using System;
using static System.Console;

Clear();

Write("Введите чило: ");
int x = int.Parse(ReadLine());

for (int i = 1; i <= x; i++)
{
    Write($"{Math.Pow(i, 3)}, ");
}

