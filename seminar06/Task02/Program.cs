/* **Задача 42:**Напишите программу, которая будет преобразовывать десятичное число в двоичное.

45 -> 101101

3 -> 11

2 -> 10 */
using System;
using static System.Console;

Clear();
WriteLine("Введите число: ");
int namber = int.Parse(ReadLine());

WriteLine(Preobraz2(namber, 2));

string Preobraz2(int n, int osn)
{
    string result = "";
    while (n >= 1)
    {
        result = $"{(n % osn)}" + result;
        n /= osn;
    }
    return result;
}
