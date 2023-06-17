//Задача 4: Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Clear();

Console.Write("Enter number a:");

int a = int.Parse(Console.ReadLine());

Console.Write("Enter number b:");

int b = int.Parse(Console.ReadLine());

Console.WriteLine("Enter number c:");

int c = int.Parse(Console.ReadLine());

int max = 0;

if (max < a) max = a;


if (max < b) max = b;


if (max < c) max = c;


Console.WriteLine($"max is {max}");
