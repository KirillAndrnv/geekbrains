﻿//Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

// a = 5; b = 7 ->  max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Clear();

Console.Write("Enter number a:");

int a = int.Parse(Console.ReadLine());

Console.Write("Enter number b:");

int b = int.Parse(Console.ReadLine());

if (a == b)
{
    Console.WriteLine("Same numbers");
}
if (a > b)
{
    Console.WriteLine($"{a} is bigger than {b}");
}
if (b > a)
{
    Console.WriteLine($"{b} is bigger than {a}");
} 

