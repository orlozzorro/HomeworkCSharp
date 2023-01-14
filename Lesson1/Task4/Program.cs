// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число больше 1 : ");
string? stringValue1 = Console.ReadLine();

int value1 = Convert.ToInt32(stringValue1);
int i = 2;
string output = "";
if (value1 > 1)
{
    while(i <= value1)
    {
        output = output + $"{i} ";
        i += 2;
    } 
    Console.WriteLine($"{value1} -> {output}");
}
else Console.WriteLine($"Введенное число {value1} меньше 1");