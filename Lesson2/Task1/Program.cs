// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondDigit(int number)
{
    int result = number % 100;
    result = result / 10;
    return result;
}

Console.Write("Введите трехзначное число: ");
int i = Convert.ToInt32(Console.ReadLine());
if (i>99 && i <1000) Console.WriteLine($"Во введеном числе {i} вторая цифра: {SecondDigit(i)}.");
else Console.WriteLine($"Введено не трёхзначное значное число");
