
========================================================================

**Обработка ошибки если ввели не число**

if(!int.TryParse(ReadLine(),out number))
{
    WriteLine("Ошибка ввода числа!");
    return;
}

// или так

int number = 0;

bool success = int.TryParse(input, out number);
if (!success)
{
    WriteLine("Введены не корректные данные...");
    return;
}
========================================================================

**Сокращенное если**

Условие ?Если Истина:Если ложь

Задача 16:

Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

using System;
using static System.Console;

Clear();

//int number=new Random().Next(10,100);
int number=79;
WriteLine($"Случайное число =  {number}");

string answer=number/10>number%10
?$"Максимальное число = {number/10}"
:number/10<number%10
    ?$"Максимальное число = {number%10}"
    :"Числа равны";

WriteLine(answer);

========================================================================

**Джойним коллекции**

//Показывал преподаватель:
// int[] GetRandomArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return result;
// }

//WriteLine(String.Join("," array))

========================================================================
// СокрЛП - удаление не значимых пробелов
int[] GetArrayFromString(string arrayStr)
{
    string[] arS=arrayStr.Split(' ',StringSplitOptions.RemoveEmptyEntries);
    int[] result=new int[arS.Length];
    for(int i=0; i<arS.Length;i++)
    {
        result[i]=int.Parse(arS[i]);
    }
    return result;
}