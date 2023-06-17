// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Clear;

Console.WriteLine ("Enter num a:");

int a = int.Parse (Console.ReadLine());

Console.WriteLine ("Enter num b:");

int b = int.Parse (Console.ReadLine());

Console.WriteLine ("Enter num c:");

int c = int.Parse (Console.ReadLine());

Console.WriteLine ($"Second number of num is {a}");

Console.WriteLine (a % 10);

Console.WriteLine ($"Second number of num is {b}");

Console.WriteLine (b % 10);

Console.WriteLine ($"Second number of num is {c}");

Console.WriteLine (c % 10);

