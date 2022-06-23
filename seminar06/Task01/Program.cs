/* Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
может ли существовать треугольник с сторонами такой длины. */
using System;
using static System.Console;

Clear();
WriteLine("Введите первое число: ");
int namber1 = int.Parse(ReadLine());
WriteLine("Введите второе число: ");
int namber2 = int.Parse(ReadLine());
WriteLine("Введите третье число: ");
int namber3 = int.Parse(ReadLine());

WriteLine(TreugolnikProverka(namber1, namber2, namber3));

string TreugolnikProverka(int n1, int n2, int n3)
{
    if (n1 + n2 > n3 && n1 + n3 > n2 && n2 + n3 > n1)
    {
        return "ДА";
    }
    else
    {
        return "НЕТ";
    }
}

