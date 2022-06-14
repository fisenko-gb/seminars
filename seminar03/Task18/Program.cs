using System;
using static System.Console;

Clear();

Write("Введите номер четверти: ");
int x = int.Parse(ReadLine());

string result;

if (x == 1)
{
    result = "x > 0 && y > 0";
}else if (x == 2)
{
    result = "x < 0 && y > 0";
}else if (x == 3)
{
    result = "x < 0 && y < 0";
}else
{
    result = "x > 0 && y < 0";
}

WriteLine($" Координаты введенной четверти: {result}");