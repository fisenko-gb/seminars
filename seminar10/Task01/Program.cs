/* **Задача 70:**Напишите программу, которая на вход принимает два числа (порядок ряда и длину) и выдаёт первые N чисел, для которых каждое следующее равно сумме двух предыдущих.

3 и 4, N = 5-> 3 4 7 11 18

6 и 10, N = 4-> 6 10 16 26 */
using System;
using static System.Console;
using System.Linq;

Clear();

WriteLine("Введите первое число ряда: ");
int n = int.Parse(ReadLine());
WriteLine("Введите второе число ряда: ");
int k = int.Parse(ReadLine());


WriteLine("Введите длину ряда: ");
int stop = int.Parse(ReadLine());

Posledovatelnost(n, k, stop);

void Posledovatelnost(int number1, int number2, int i)
{
    if (i == 0)
    {
        return;
    }
    Write($"{number1}, ");
    Posledovatelnost(number2, number1 + number2, i - 1);
}



