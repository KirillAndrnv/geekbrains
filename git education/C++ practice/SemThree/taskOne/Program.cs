﻿Console.Clear;
Console.Write ("Enter x:");
int x = int.Parse(Console.ReadLine());


Console.Write ("Enter y:");
int y = int.Parse(Console.ReadLine());

if(x > 0 && y > 0)
{ 
    Console.WriteLine("1");
}else

if(x < 0 && y > 0)
{ 
    Console.WriteLine("2");
}else

if(x < 0 && y < 0)
{ 
    Console.WriteLine("3");
}else

if(x > 0 && y < 0)
{ 
    Console.WriteLine("4");
}else

Console.WriteLine("On the os");
