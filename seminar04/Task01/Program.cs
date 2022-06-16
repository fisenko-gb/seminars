/* Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

456 -> 3

78 -> 2

89126 -> 5 */
using System;
using static System.Console;
Clear();

Write("Введите число: ");
int num = int.Parse(ReadLine());

int getlength(int number)
{
    int length = 0;
    for (int i=1; i <= number; i*=10)
    {
        length++;
    }
    return length;
}

int getlength2(int number)
{
    int i = 1;
    int length = 0;
    while(i <= number)
    {
        length++;
        i*=10;
    }
    return length;
}

WriteLine($"Метод 1:{getlength(num)}");
WriteLine($"Метод 2:{getlength2(num)}");


