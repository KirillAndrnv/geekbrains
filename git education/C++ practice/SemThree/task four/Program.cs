// // 20 Напишите программу, 
// которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.

// A (3,6); B(2, 1)-> 5,09
// A(7, -5); B(1, -1)-> 7,21
//sqrt((3 - 2)^2 + (6 - 1)^2) = 5.09
//double s = Math.Sqrt(...);

Console.Write ("Enter x1:");
int x1 = int.Parse(Console.ReadLine());

Console.Write ("Enter y1:");
int y1 = int.Parse(Console.ReadLine());

Console.Write ("Enter x2:");
int x2 = int.Parse(Console.ReadLine());

Console.Write ("Enter y2:");
int y2 = int.Parse(Console.ReadLine());

double s = Math.Sqrt((Math.Pow(x1 - y1,2) + Math.Pow(x2 - y2,2)));

Console.WriteLine($"distance {s}");
//
//Console.WriteLine($"distance {s:f1}"); округление после первого знака


