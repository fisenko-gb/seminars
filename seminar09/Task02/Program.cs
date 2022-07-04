/* **Задача 65:**Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 5, 6, 7, 8" */
using System;
using static System.Console;

Clear();

Write("Введите число M: ");
int m = Convert.ToInt32(ReadLine());
Write("Введите число N: ");
int n = Convert.ToInt32(ReadLine());

Print(m, n);

void Print(int i, int j)
{
    int k = i;
    int x = j;
    if (k == x + 1)
    {
        return;
    }
    if (k < x)
    {
        k = i;
        x = j;
    }
    else
    {
        k = j;
        x = i;
    }
    Write($"{k}, ");
    k++;

    Print(k, x);
}
