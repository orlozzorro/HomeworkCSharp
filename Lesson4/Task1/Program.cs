// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Promt(string message)
{
    Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int Exponentiate(int a, int b)
{
    int result = a;
    for (int i = 1; i < b; i++)
    {
        result *= a;
    }
    return result;
}

int a = Promt("Введите число А");
int b = Promt("Введите число B");
System.Console.WriteLine($"числов {a} в степени  {b} = {Exponentiate(a, b)}");