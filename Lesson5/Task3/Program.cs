// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] GenerateArray(int len)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 100);
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write($"{item}\t");
    }
    System.Console.WriteLine();
}

int MaxMinDiff(int[] array)
{
    int max = array[0];
    int min = array[0];
    int result;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    result = max - min;
    return result;
}
int[] array = GenerateArray(12);

System.Console.WriteLine($"Сгенерирован массив:");
PrintArray(array);
System.Console.WriteLine($"Разница между минимальным и максимальным числом в массиве = {MaxMinDiff(array)}");