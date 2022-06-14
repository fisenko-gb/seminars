using System;
using static System.Console;

Clear();

Write("Введите координату Х первой точки: ");
int x1 = int.Parse(ReadLine());
Write("Введите координату У первой точки: ");
int y1 = int.Parse(ReadLine());
Write("Введите координату Х второй точки: ");
int x2 = int.Parse(ReadLine());
Write("Введите координату У второй точки: ");
int y2 = int.Parse(ReadLine());

int x = x1 - x2;
int y = y1 - y2;

double rezault = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

WriteLine($"Расстояние между точками: {rezault}");