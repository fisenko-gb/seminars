//**Задача 64:** Задайте значения M и N. Напишите программу, которая выведет произведение натуральных чисел в промежутке от M до N.
using System;
using static System.Console;

Clear();

Write("Введите число M: ");
int start = Convert.ToInt32(ReadLine());
Write("Введите число N: ");
int stop = Convert.ToInt32(ReadLine());

Write(start < stop ? Multiplication(start, stop) : Multiplication(stop, start));

int Multiplication(int m, int n)
{
    
    if (m > n)
    {
        return 1;
    }
    
    return m * Multiplication(m + 1, n);
   
}
