// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbers(int numberM, int numberN)
{
    if (numberM > numberN)
    {
        return 0;
    }
    return numberM + SumNumbers(numberM + 1, numberN);
}

int m = 4;
int n = 8;
System.Console.Write($"M = {m}; N = {n} -> {SumNumbers(m, n)}");