/* **Задача 13:** Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */
using System;
using static System.Console;

Clear();

int number = new Random().Next(1, 100000);
WriteLine($"Случайное число =  {number}");

if (number < 100)
{
    WriteLine("третьей цифры нет");
    return;
}

WriteLine(number.ToString()[2]);