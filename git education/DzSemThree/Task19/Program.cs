// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.Write("Eenter a five-digit number: ");
string number = Console.ReadLine();

void CheckingNumber(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"Number: {number} - polyndrome.");
  }
  else Console.WriteLine($"Number: {number} - not polyndrome.");
}

if (number!.Length == 5)
{
  CheckingNumber(number);
}
else Console.WriteLine($"Wrong Number");

 