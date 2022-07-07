/* **Задача 71:**В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита.

n = 2 -> аа, ии, сс, вв, аи, иа, ис, си, ас, са, ав, ва, ви, ив, св, вс */


using System;
using static System.Console;
using System.Linq;

Clear();

WriteLine("Введите длину слова: ");
int n = int.Parse(ReadLine());

string alfavit = "аисв";

Slovo(alfavit, n, "");

void Slovo(string alf, int dlina, string tStroka)
{

    if (dlina == 0)
    {
        WriteLine(tStroka);
    }
    else
    {

        foreach (char c in alf)
        {
            Slovo(alf, dlina - 1, tStroka + c);
        }
    }
}



