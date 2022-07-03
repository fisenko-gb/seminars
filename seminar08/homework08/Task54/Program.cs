/* **Задача 54:**Задайте двумерный массив.Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

    Например, задан массив:
	
	1 4 7 2
	
	5 9 2 3
	
	8 4 2 4


    В итоге получается вот такой массив:
	
	1 2 4 7
	
	2 3 5 9
	
	2 4 4 8 */
using System;
using static System.Console;
using System.Linq;

Clear();

WriteLine("Введите размер матрицы через пробел: ");
string[] sizeS = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int m = int.Parse(sizeS[0]);
int n = int.Parse(sizeS[1]);
WriteLine("-----------------------------------------------------------------------------------");

int[,] mainArray = GetMatrix(m, n);
PrintMatrix(mainArray);
WriteLine("-----------------------------------------------------------------------------------");

SortArray(mainArray);
PrintMatrix(mainArray);
WriteLine("-----------------------------------------------------------------------------------");

void SortArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int[] rezult = new int[array.GetLength(1)];
        int n = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            rezult[n] = array[i, j];
            n++;
        }

        Array.Sort(rezult);
        Array.Reverse(rezult);

        n = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rezult[n];
            n++;
        }
    }

}

int[,] GetMatrix(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, 11);
        }
    }
    return result;
}

void PrintMatrix(int[,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            Write($"{result[i, j]} \t ");
        }
        WriteLine();
    }
}



