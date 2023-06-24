// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write ("Enter the numer x:");

int x = int.Parse(Console.ReadLine());

int[] result = new int[x];//int[] -массив целых чисел

for (int i = 1; i <= x; i++)
    result[i - 1] = i * i * i;

for (int i = 0; i < x; i++)

Console.Write ($"{result[i]} ");




