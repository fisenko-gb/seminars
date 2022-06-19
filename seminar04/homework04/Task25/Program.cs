/* **Задача 25:**Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4-> 16

-- - */
using System;
using static System.Console;

Clear();

while (true)
{
    Write("Введите число (или \"stop\" для завершения): ");
    string otvet = ReadLine();

    if (otvet.ToLower() == "stop" || otvet.ToLower() == "стоп")
    {
        WriteLine("Программа завершена.");
        break;
    }

    double number = double.Parse(otvet);

    Write("Введите степень числа: ");
    double stepen = double.Parse(ReadLine());

    double rezult = Math.Pow(number, stepen);

    WriteLine($"{number} в степени {stepen} = {rezult}");

}