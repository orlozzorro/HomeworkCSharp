// Задача 4 * : Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. Не использовать строки для расчета.

int DeleteSecondDigit(int number)
{
    int a = number / 100;
    int b = number % 10;
    int result = a * 10 + b;
    return result;
}

// int gen = 0;
// while(gen < 101)
// {
int i = new Random().Next(100, 1000);
Console.WriteLine($"Сгенерировано число: {i}");
Console.WriteLine($"Новое число без второй цифры: {DeleteSecondDigit(i)}");
// gen++;
// }//