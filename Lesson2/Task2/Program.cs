// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ThirdDigit(int number)
{
    int result = number;
    while (result > 1000) // уменьшаем число до 3 знаков
    {
        result = result / 10;
    }
    result = result % 10;
    return result;
}

Console.Write("Введите число: ");
int i = Convert.ToInt32(Console.ReadLine());
if (i>99) Console.WriteLine($"Во введеном числе {i} третья цифра: {ThirdDigit(i)}.");
else Console.WriteLine($"Во введенном числе {i} третьей цифры нет");