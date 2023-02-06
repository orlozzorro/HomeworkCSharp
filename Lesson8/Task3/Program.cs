// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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
//вычленяем строки и столбцы из входящих массивов
int[] LineOfMatrix(int lineNumber, int[,] array1, bool row)
{
    int[] resultArray = new int[array1.GetLength(0)];
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        if (row) resultArray[i] = array1[lineNumber, i];
        else resultArray[i] = array1[i, lineNumber];
    }
    return resultArray;
}

//заполняем итоговую матрицу
int[,] MatrixMultiplication(int[,] array1, int[,] array2)
{
    int rows = array1.GetLength(0);
    int columns = array2.GetLength(1);
    int[,] resultArray = new int[rows, columns];
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        int[] linesOfArray1 = LineOfMatrix(i, array1, true);

        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            int[] columnsOfArray2 = LineOfMatrix(j, array2, false);
            resultArray[i, j] = ElementOfMatrix(linesOfArray1, columnsOfArray2);
        }
    }
    return resultArray;
}

int ElementOfMatrix(int[] array1, int[] array2)
{
    int sum = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        sum += array1[i] * array2[i];
    }
    return sum;
}

System.Console.WriteLine("Matrix-1");
int[,] array1 = GenerateArray(2, 3);
PrintArray(array1);

System.Console.WriteLine("Matrix-2");
int[,] array2 = GenerateArray(2, 2);
PrintArray(array2);
if (array1.GetLength(1) == array2.GetLength(0))
{
    System.Console.WriteLine("==========Matrix Multiplication========");
    int[,] result = MatrixMultiplication(array1, array2);
    PrintArray(result);
}
else System.Console.WriteLine("Умножение матриц невозможно");