// // Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int Promt(string message)
{
    Console.Write($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}
int[] TakeNumbers(int count)
{
    int[] array = new int[count];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Promt($"Введите число [{i + 1}] = ");
    }
    return array;
}
int CountPositive(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) result++;
    }
    return result;
}





int count = Promt("Какое количество чисел вы будите вводить >");
if (count > 0) System.Console.WriteLine($"Введено {CountPositive(TakeNumbers(count))} положительных число/числа/чисел");
else System.Console.WriteLine("не может быть меньше 0");