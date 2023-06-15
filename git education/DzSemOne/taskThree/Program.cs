//Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.Clear();

Console.Write("Enter number a:");

int a = int.Parse(Console.ReadLine());

Console.Write("Enter number b:");

int b = int.Parse(Console.ReadLine());

Console.WriteLine("Enter number c:");

int c = int.Parse(Console.ReadLine());

if (a %2 == 0)
{
    Console.WriteLine("even");
}
else
{
    Console.WriteLine("not even");
}
if (b %2 == 0)
{
    Console.WriteLine("even");
}
else
{
    Console.WriteLine("not even");
}
if (c %2 == 0)
{
    Console.WriteLine("even");
}
else
{
    Console.WriteLine("not even");
}