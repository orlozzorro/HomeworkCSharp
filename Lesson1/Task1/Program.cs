// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите число a: ");
string? stringValue1 = Console.ReadLine();
Console.Write("Введите число b: ");
string? stringValue2 = Console.ReadLine();

int value1 = Convert.ToInt32(stringValue1);
int value2 = Convert.ToInt32(stringValue2);

if (value1 > value2) Console.WriteLine($"число a = {value1}, больше чем число b = {value2}");
if (value2 > value1) Console.WriteLine($"число b = {value2}, больше чем число a = {value1}");
if (value1 == value2) Console.WriteLine($"число a = {value1} равно числу b = {value2}");