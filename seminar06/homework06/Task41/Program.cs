/***Задача 41:** Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3*/
using System;
using static System.Console;

Clear();
WriteLine("Введите числа через запятую: ");
string[] arrayStr = ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);
Write($"{String.Join(", ", arrayStr)} -> {GetPozitiv(arrayStr)}");

int GetPozitiv(string[] arrayStr)
{
    int result = 0;
    for(int i=0; i < arrayStr.Length; i++)
    {
        if(int.Parse(arrayStr[i]) > 0)
        {
            result++;
        }        
    }
    return result;
}
