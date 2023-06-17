// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Write ("what quarter:");
int n = int.Parse(Console.ReadLine());

if (n == 1)
{
    Console.WriteLine("First quarter x < 0; y > 0");
}else
if (n ==2)
{
    Console.WriteLine("second quarter x > 0; y > 0 ");
}else
if (n == 3)
{
    Console.WriteLine("Third quarter x < 0; y < 0 ");
}else
if (n == 4)
{
    Console.WriteLine("Four quarter x > 0; y < 0");
}else
Console.WriteLine ("Error");

//switch (quarter)

{
    case 1:{
        Console.WriteLine("x>0 y>0");
        break;
        }
    case 2:{
        Console.WriteLine("x<0 y>0");
        break;
        }
    case 3:{
        Console.WriteLine("x<0 y<0");
        break;
        }
    case 4:{
        Console.WriteLine("x>0 y<0");
        break;
        }
    default:{
        Console.WriteLine("Введена неправильная четверть");
        break;
        }
