Console.WriteLine("Введите 2 числа для определения большего из них");
int firstNumber, secondNumber;
Console.Write("Введите первое число: ");
firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
secondNumber = Convert.ToInt32(Console.ReadLine());
 
if (firstNumber > secondNumber)
{
    Console.WriteLine($"max = {firstNumber}");
}
else
{
    Console.WriteLine($"max = {secondNumber}");
}