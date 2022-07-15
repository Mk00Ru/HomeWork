//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт максимальное из этих чисел.

int a = 2;
int b = 10;
int max = a;

if (a < b) max = b;

Console.Write("max = ");
Console.WriteLine(max);