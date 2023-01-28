// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] GenerateArray(int len)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-9, 10);
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

int SumEvenArrayIndexes(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i += 2)
    {
        sum = sum + array[i];
    }
    return sum;
}
int[] array = GenerateArray(5);

System.Console.WriteLine($"Сгенерирован Массив:");
PrintArray(array);
System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {SumEvenArrayIndexes(array)}");