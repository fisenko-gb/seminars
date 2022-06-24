/* **Задача 43:** Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5) (ответы под вопросом) */
using System;
using static System.Console;

Clear();
WriteLine("Введите b1: ");
double b1 = double.Parse(ReadLine());
WriteLine("Введите k1: ");
double k1 = double.Parse(ReadLine());
WriteLine("Введите b2: ");
double b2 = double.Parse(ReadLine());
WriteLine("Введите k2: ");
double k2 = double.Parse(ReadLine());
double[] array = GetFormula(b1, b2, k1, k2);
Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({array[0]}; {array[1]})");


double[] GetFormula(double b1, double b2, double k1, double k2)
{
    double[] result = new double[2];
    result[0] = (b2 - b1) / (k1 - k2);
    result[1] = k1 * result[0] + b1;
    return result;        
}
