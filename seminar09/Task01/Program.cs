/* **Задача 63:**Задайте значение N.Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

N = 5-> "1, 2, 3, 4, 5"

N = 6-> "1, 2, 3, 4, 5, 6" */
using System;
using static System.Console;
using System.Linq;

Clear();

WriteLine("Введите число: ");
int n = int.Parse(ReadLine());
int i = 1;

Print(i, n);

void Print(int i, int n)
{
    if (i == n + 1)
    {
        return;
    }
    Write($"{i}, ");
    i++;

    Print(i, n);
}