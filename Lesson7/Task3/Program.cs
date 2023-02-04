// Задача 3: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}
String AverageColumns(int[,] array)
{
    string result = "";
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0.0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        result = result + $"{Math.Round(sum / array.GetLength(0), 2)} \t";
    }

    return $"Среднее арифметическое каждого столбца: \n{result}";
}
int[,] array = GenerateArray(3, 4);
PrintArray(array);
System.Console.WriteLine(AverageColumns(array));