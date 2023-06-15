// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"
Console.Clear();
Console.Write("Write number N:");

int N = int.Parse(Console.ReadLine());
 
int a = -N;

while (a <= N)
{
    Console.Write($"{a}, ");
    a++;
}

