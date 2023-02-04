// Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого числа в массиве нет
// 1, 2 -> 4
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
int InputInt(string message)
{
    System.Console.Write($"{message}: ");
    return int.Parse(Console.ReadLine());
}
int GetPosition(int i, int j, int[,] array)
{
    int row = i-1;
    int column = j-1;
   
    if (row >= array.GetLength(0) || 
        column >= array.GetLength(1) ||
        row < 0 ||
        column < 0) 
        {
            return -1;
        }
    return array[row, column];
}

int[,] array = GenerateArray(3, 4);
PrintArray(array);
int i = InputInt("Введите строку");
int j = InputInt("Введите столбец");
if (GetPosition(i, j, array) != -1) System.Console.WriteLine($"array[{i},{j}] = {GetPosition(i, j, array)}");
else System.Console.WriteLine("такого числа в массиве нет");