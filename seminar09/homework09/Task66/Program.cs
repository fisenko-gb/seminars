/* **Задача 66:** Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
using System;
using static System.Console;

Clear();

Write("Введите число M: ");
int start = Convert.ToInt32(ReadLine());
Write("Введите число N: ");
int stop = Convert.ToInt32(ReadLine());

Write(start < stop ? Summa(start, stop) : Summa(stop, start));

int Summa(int m, int n)
{
    
    if (m > n)
    {
        return 0;
    }
    
    return m + Summa(m + 1, n);
   
}

