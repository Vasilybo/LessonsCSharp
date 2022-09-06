// 1 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


Console.Write("Введи трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());

while (threeDigitNumber < 1000)
{
    int n = threeDigitNumber / 10;
    if (n < 0) n = -n;
    int result = n % 10;
    Console.WriteLine($"Вторая цифра этого числа: {result}");
    break;
}

