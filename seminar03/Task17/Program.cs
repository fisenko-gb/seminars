using System;
using static System.Console;

Clear();

Write("Введите Х: ");
int x = int.Parse(ReadLine());
Write("Введите Y: ");
int y = int.Parse(ReadLine());
int quater = 0;

if (x > 0 && y > 0)
{
    quater = 1;
}else if (x < 0 && y > 0)
{
    quater = 2;
}else if (x < 0 && y < 0)
{
    quater = 3;
}else//if (x > 0 && y < 0)
{
    quater = 4;
}

WriteLine($"{quater} четверть");