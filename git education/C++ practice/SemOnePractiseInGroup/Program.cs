// a = 25; b = 5->да
// a = 2 b = 10->нет
// a = 9; b = -3->да
// a = -3 b = 9->нет


Console.Clear();
Console.Write("Enter the number a:");

int a = int.Parse(Console.ReadLine());

Console.Write("Enter the number b:");

int b = int.Parse(Console.ReadLine());


int sqr = a * a;

if (sqr == b)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}

Console.WriteLine($"Square {a} Is {sqr}");


