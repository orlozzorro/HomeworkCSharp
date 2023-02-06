// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.

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
void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(0); j++) //индийский код?
        {
            int k = j;
            while(array[i,k] > array[i,k-1])
            {
                int temp = array[i, k-1];
                array[i,k-1] = array[i,k];
                array[i,k] = temp;
                if (k != 1) k--;
            }
        }
    }
}
int[,] array = GenerateArray(5, 5);
System.Console.WriteLine("========Base Array=======");
PrintArray(array);
SortArray(array);
System.Console.WriteLine("========Sorted Array=======");
PrintArray(array);