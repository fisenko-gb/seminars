/* **Задача 69:**Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

A = 3; B = 5-> 243(3⁵)

A = 2; B = 3-> 8 */
using System;
using static System.Console;

Clear();

Write("Введите первое число: ");
int a = Convert.ToInt32(ReadLine());
Write("Введите второе число: ");
int b = Convert.ToInt32(ReadLine());

WriteLine(Rezult(a, b));

int Rezult(int numbers, int i)
{
    if (i == 0)
    {
        return 1;
    }


    return numbers *= Rezult(numbers, i - 1);

}