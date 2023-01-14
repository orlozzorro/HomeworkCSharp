// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите число 1: ");
string? stringValue1 = Console.ReadLine();
Console.Write("Введите число 2: ");
string? stringValue2 = Console.ReadLine();
Console.Write("Введите число 3: ");
string? stringValue3 = Console.ReadLine();

int value1 = Convert.ToInt32(stringValue1);
int value2 = Convert.ToInt32(stringValue2);
int value3 = Convert.ToInt32(stringValue3);

//Индийский код
// if (value1 >= value2) 
// {
//     if (value1 >= value3) Console.WriteLine($"Из введенных чисел {value1}, {value2}, {value3} Максимальное число {value1}");
//     else Console.WriteLine($"Из введенных чисел {value1}, {value2}, {value3} Максимальное число {value3}");
// }
// else
// {
//     if (value2 >= value3) Console.WriteLine($"Из введенных чисел {value1}, {value2}, {value3} Максимальное число {value2}");
//     else Console.WriteLine($"Из введенных чисел {value1}, {value2}, {value3} Максимальное число {value3}");
// }
int maxNumber = value1;
if (value2 > maxNumber) maxNumber = value2;
if (value3 > maxNumber) maxNumber = value3;
Console.WriteLine($"Из введенных чисел {value1}, {value2}, {value3} Максимальное число {maxNumber}");