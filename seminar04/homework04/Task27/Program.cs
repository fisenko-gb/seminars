/* **Задача 27:**Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12

--- */
using System;
using static System.Console;

Clear();

Write("Введите число: ");
string input = ReadLine();
int length = input.Length;
int number = Convert.ToInt32(input);

int summa = SumNum(number, length);
WriteLine($"Сумма всех цифр в числе {input} = {summa}");

int SumNum(int number, int length)
{
    int temp = 0;
    int result = 0;

    for (int i = 0; i < length; i++)
    {
        temp = number - number % 10;
        result = result + (number - temp);
        number = number / 10;
    }

    return result;
}






