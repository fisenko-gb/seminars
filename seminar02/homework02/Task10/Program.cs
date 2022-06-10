// **Задача 10:** Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает **вторую** цифру этого числа.

// 456 -> 5
// 782 ->  8
// 918  -> 1
using System;
using static System.Console;

Clear();

int number = new Random().Next(100,999);
WriteLine($"Случайное число =  {number}");

number = number/10%10;
WriteLine($"Вторая цифра в числе: {number}");