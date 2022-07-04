// **Задача 67:**Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

// 453 -> 12

// 45 -> 9
using System;
using static System.Console;

Clear();

Write("Введите число: ");
int m = Convert.ToInt32(ReadLine());

WriteLine(Rezult(m));

int Rezult(int numbers)
{
    if (numbers < 1)
    {
        return 0;
    }

    return numbers % 10 + Rezult(numbers / 10);
}

