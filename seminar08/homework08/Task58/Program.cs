/* **Задача 58:**Задайте две матрицы.Напишите программу, которая будет находить произведение двух матриц.


    Например, заданы 2 массива:
	
	1 4 7 2
	
	5 9 2 3
	
	8 4 2 4
	
	5 2 6 7


    и
	
	1 5 8 5
	
	4 9 4 2
	
	7 2 2 6
	
	2 3 4 7


    Их произведение будет равно следующему массиву:
	
	1 20 56 10
	
	20 81 8 6
	
	56 8 4 24
	
	10 6 24 49 */
using System;
using static System.Console;
using System.Linq;

Clear();

WriteLine("Введите размер матриц через пробел: ");
string[] sizeS = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int m = int.Parse(sizeS[0]);
int n = int.Parse(sizeS[1]);
WriteLine("-----------------------------------------------------------------------------------");

int[,] array1 = GetMatrix(m, n);
PrintMatrix(array1);
WriteLine("-----------------------------------------------------------------------------------");
int[,] array2 = GetMatrix(m, n);
PrintMatrix(array2);
WriteLine("-----------------------------------------------------------------------------------");

int[,] rezult = CompositionMatrix(array1, array2);
PrintMatrix(rezult);
WriteLine("-----------------------------------------------------------------------------------");

int[,] CompositionMatrix(int[,] a, int[,] b)
{

    int[,] result = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                result[i, j] += a[i, k] * b[k, j];
            }
        }
    }
    return result;
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





