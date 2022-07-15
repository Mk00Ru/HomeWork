//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int i = 1;

Console.WriteLine("Четные числа от 1 до " + n + ": ");

while (i <= n) 
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
    i++;
}