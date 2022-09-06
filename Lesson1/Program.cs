// 1 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.WriteLine("Введите 2 числа для определения большего из них");
// int firstNumber, secondNumber;
// Console.Write("Введите первое число: ");
// firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// secondNumber = Convert.ToInt32(Console.ReadLine());
 
// if (firstNumber > secondNumber)
// {
//     Console.WriteLine($"max = {firstNumber}");
// }
// else
// {
//     Console.WriteLine($"max = {secondNumber}");
// }


// 2 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


// Console.WriteLine("Введите 3 числа для определения большего из них");
// int firstNumber, secondNumber, thirdNumber;
// Console.Write("Введите первое число: ");
// firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// secondNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число: ");
// thirdNumber = Convert.ToInt32(Console.ReadLine());

// int max = firstNumber;
// if (secondNumber > max)
// {
// Console.WriteLine($"max = {secondNumber}");
// }
// if (thirdNumber > max) 
// {
// Console.WriteLine($"max = {thirdNumber}");
// }
// else 
// {
// Console.WriteLine($"max = {firstNumber}"); 
// }


// 3 Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).


// Console.Write("Введите число, чтобы определить четное ли оно: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number % 2 == 0)
// {
//     Console.WriteLine($"{number}: четное");
// }
// else 
// {
//     Console.WriteLine($"{number}: нечетное");
// }


// 4 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

int x = 0;
while (x < number)
{
if (number % 2 == 0)            
Console.WriteLine(x += 2);
}
