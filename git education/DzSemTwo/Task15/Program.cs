// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Write day number: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("(Weekend) -> yes");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("There is no day of the week");
  }
  else Console.WriteLine("(Weekend) -> NO");
}
CheckingTheDayOfTheWeek(dayNumber);
