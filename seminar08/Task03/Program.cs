// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
/* Если набор данных — таблица:
1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза */
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

int[] rezArray = MatrixToArray(mainArray);
PrintArray(rezArray);
WriteLine("-----------------------------------------------------------------------------------");

rezArray = rezArray.OrderBy(x => x).ToArray(); // сортировка

CounterElements(rezArray);



void CounterElements(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        if (i > 0 && array[i] == array[i - 1])
        {
            continue;
        }

        FindNumbers(array[i], array);

    }

}

void FindNumbers(int n, int[] array)
{
    int ch = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] == n)
        {
            ch++;
        }

    }
    WriteLine($"Число {n} встречается {ch} раз.");
}

int[] MatrixToArray(int[,] array)
{
    int[] rezult = new int[array.GetLength(0) * array.GetLength(1)];
    int n = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            rezult[n] = array[i, j];
            n++;
        }

    }
    return rezult;
}

int[,] GetMatrix(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(-10, 11);
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

void PrintArray(int[] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {

        Write($"{result[i]} \t ");

    }
    WriteLine();
}

