using System;
using static System.Console;

Clear();

Write("Введите номер четверти: ");
int x = int.Parse(ReadLine());

string result;

switch (x)
{
    case 1: 
    {
        result = "x > 0 && y > 0";
        break;
    }
    case 2:
    {
        result = "x < 0 && y > 0";
        break;
    }
    case 3:
    {
        result = "x < 0 && y < 0";
        break;
    }
    case 4:
    {
        result = "x > 0 && y < 0";
        break;
    }
    default: 
    {
        result = " не возможно определить, данные введены не корректно...";
        break;
    }
}

WriteLine($" Координаты введенной четверти: {result}");