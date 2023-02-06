// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int[,] GenerateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write($"Строка {i + 1} \t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine("\n___________________________________");
    }
}

int[] SumRows(int[,] array)
{
    int[] minSum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        minSum[i] = sum;
    }
    return minSum;
}

int MinSumRow(int[] array)
{
    int minimalValue = array[0];
    int minimailIndex = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minimalValue) 
        {
            minimalValue = array[i];
            minimailIndex = i;
        }
    }
    return minimailIndex;
}

int[,] array = GenerateArray(5, 3);
PrintArray(array);
int[] sumRows = SumRows(array);
System.Console.WriteLine($"Минимальная сумма в строке: {MinSumRow(sumRows) + 1}");
