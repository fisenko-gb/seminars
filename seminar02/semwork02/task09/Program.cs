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