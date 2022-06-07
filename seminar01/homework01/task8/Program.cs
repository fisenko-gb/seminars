/* Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */

int a;

Console.Clear();
Console.Write("Введите число больше 1: ");
a = Convert.ToInt32(Console.ReadLine());

if (a <= 1)
{
    Console.WriteLine("Ошибка, введенное число противоречит условиям...");
    return;
}

for (int i = 1; i <= a; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + ", ");
    }
}



