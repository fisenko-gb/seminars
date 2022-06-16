/* **Задача 28:**

Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

4  -> 24
5  -> 120 */
using System;
using static System.Console;
Clear();

Write("Введите число: ");
int num = int.Parse(ReadLine());

int getProiz(int number)
{
    int rezult = 1;

    for (int i = 1; i <= number; i++)
    {
        rezult *= i;
    }

    return rezult;
}

WriteLine($"Произведение всех чисел: {getProiz(num)}");


