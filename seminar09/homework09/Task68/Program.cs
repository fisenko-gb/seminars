// **Задача 68:** Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 3, n = 2 -> A(m,n) = 29
using System;
using static System.Console;

Clear();

Write("Введите число M: ");
int start = Convert.ToInt32(ReadLine());
Write("Введите число N: ");
int stop = Convert.ToInt32(ReadLine());

Write(Aker(start, stop));

int Aker(int m, int n)
{

    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Aker(m - 1, 1);
    }
    else
    {
        return Aker(m - 1, Aker(m, n - 1));
    }

}
