// Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов. 
// Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. 
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2


int[,] GenerateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(0, 10);
        }
    }
    return array;
}

int SumMaxFromArray(int[,] array)
{
    int sumMax = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int maxValue = array[i,0];
        for (int j = 0; j < array.GetLength(1); j++)
        {
           if (array[i,j] > maxValue) maxValue = array[i,j];
        }
        sumMax += maxValue;
    }
    return sumMax;
}

int MinValuesInColumns(int[,] array)
{
    int sumMin = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int minValue = array[0, j];
        for (int i = 0; i < array.GetLength(0); i++)
        {
           if (array[i,j] < minValue) minValue = array[i,j];
        }
        sumMin += minValue;
    }
    return sumMin;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           System.Console.Write($"{array[i,j]}\t");
        }
        System.Console.WriteLine();
    }
}

int[,] array = GenerateArray(3, 5);
PrintArray(array);
System.Console.WriteLine($"сумма максимумов Строк = {SumMaxFromArray(array)}. Сумма минимумов столбцов {MinValuesInColumns(array)}, разность = {SumMaxFromArray(array) - MinValuesInColumns(array)}");

