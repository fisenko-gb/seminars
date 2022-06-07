/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

int a,max;

Console.Clear();
Console.Write("Введите первое число: ");
max = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
a = Convert.ToInt32(Console.ReadLine());
if (a > max)
{
    max = a;
}
Console.Write("Введите третье число: ");
a = Convert.ToInt32(Console.ReadLine());
if (a > max)
{
    max = a;
}
Console.WriteLine(max);