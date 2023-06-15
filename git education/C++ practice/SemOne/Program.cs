//Hz than task is it, but it work and im happy ^_^
Console.Write("Enter the number a:");
int a = int.Parse(Console.ReadLine());
//First method 
int result1 = a * a;
Console.WriteLine($"First method -> Number {a} Square is {result1}");
//Second method 
int result2 = Convert.ToInt32(Math.Pow(a, 2));
Console.WriteLine($"Second Method  -> square of {a} is {result1}");
