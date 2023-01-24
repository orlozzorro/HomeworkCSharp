// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]//ubuntu2

int Promt(string message)
{
    Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}
int[] doRndArray(int arraySize, int minValue, int maxValue)
{
    int[] arr = new int[arraySize];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}
void OutPut(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
}

int arraySize = Promt("Введите размерность массива");

if (arraySize > 0) 
{
    int minValue = Promt("Введите пороговое случайное значение (включая пороговое значение)");
    int maxValue = Promt("Введите пороговое случайное значение (включая пороговое значение)");
    if(maxValue > minValue) OutPut(doRndArray(arraySize, minValue, maxValue));
    else OutPut(doRndArray(arraySize, maxValue, minValue));
}
else System.Console.WriteLine("Ошибочная размерность массива");
