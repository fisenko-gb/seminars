/* **Задача 47**. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9 */
using System;
using static System.Console;

Clear();
Write("Введите размер массива через пробел: ");
string[] sizeS = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int rows = int.Parse(sizeS[0]);
int columns = int.Parse(sizeS[1]);

double[,] ar = GetRandomArray(rows, columns);
PrintArray(ar);

double[,] GetRandomArray(int row, int columm)
{
    double[,] rezult = new double[row, columm];

    for (int i = 0; i < rezult.GetLength(0); i++)
    {
        for (int j = 0; j < rezult.GetLength(1); j++)
        {
            int nDoouble = new Random().Next(0, 2);
            if (nDoouble == 1)
            {
                double doobleChast = new Random().NextDouble();
                rezult[i, j] = new Random().Next(-10,10) + Math.Round(doobleChast, 1);

            }
            else
            {
                rezult[i, j] = new Random().Next(-10,10);
            }
        }
    }
    return rezult;
}

void PrintArray(double[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }

}
