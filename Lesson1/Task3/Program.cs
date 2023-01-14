// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число: ");
string? stringValue1 = Console.ReadLine();

int value1 = Convert.ToInt32(stringValue1);

if ((value1%2) == 0) Console.WriteLine($"Введенное число {value1} - четное. Ответ да");
else Console.WriteLine($"Введенное число {value1} - нечетное. Ответ нет");