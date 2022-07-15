//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите первое число: ");
int b = int.Parse(Console.ReadLine());
int max = a;

if (b > max) max = b;

Console.Write("max = " + max);