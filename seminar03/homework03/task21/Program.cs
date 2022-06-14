/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */
using System;
using static System.Console;

Clear();

Write("Введите координату Х первой точки: ");
int x1 = int.Parse(ReadLine());
Write("Введите координату У первой точки: ");
int y1 = int.Parse(ReadLine());
Write("Введите координату Z первой точки: ");
int z1 = int.Parse(ReadLine());
Write("Введите координату Х второй точки: ");
int x2 = int.Parse(ReadLine());
Write("Введите координату У второй точки: ");
int y2 = int.Parse(ReadLine());
Write("Введите координату Z второй точки: ");
int z2 = int.Parse(ReadLine());

int x = x1 - x2;
int y = y1 - y2;
int z = z1 - z2;

double rezault = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));

WriteLine($"Расстояние между точками: {rezault:f2}");

