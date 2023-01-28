// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] GenerateArray(int len)
{
    double[] array = new double[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 100);
    }
    return array;
}

void PrintArray(double[] array)
{
    foreach (int item in array)
    {
        System.Console.Write($"{item}\t");
    }
    System.Console.WriteLine();
}

double MaxMinDiff(double[] array)
{
    double max = array[0];
    double min = array[0];
    double result;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    result = max - min;
    return result;
}
double[] array = GenerateArray(12);

System.Console.WriteLine($"Сгенерирован массив:");
PrintArray(array);
System.Console.WriteLine($"Разница между минимальным и максимальным числом в массиве = {MaxMinDiff(array)}");