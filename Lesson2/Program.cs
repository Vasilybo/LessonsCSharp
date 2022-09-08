1 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


Console.Write("Введите трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());

while (threeDigitNumber < 1000)
{
    int n = threeDigitNumber / 10;
    if (n < 0) n = -n;
    int result = n % 10;
    Console.WriteLine($"Вторая цифра этого числа: {result}");
    break;
}


2 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int number = n;

while (number >= 1000)
{
    if (n < 0) n = -n;
    number = number / 10;
}

int result = number % 10;

Console.WriteLine($"Третья цифра этого числа: {result}");


3 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("Выходной");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("Это не день недели");
  }
  else Console.WriteLine("Это будний день");
}

CheckingTheDayOfTheWeek(dayNumber);