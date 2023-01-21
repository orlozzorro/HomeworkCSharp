// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Promt(string message)
{
    Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int Coub(int a)
{
    return a * a * a;
}

int x = Promt("Введите число: ");
int i = 1;
while (i <= x)
{
    if (i == 1) Console.Write($"{x} -> ");
    Console.Write(Coub(i) + " ");
    i++;
}
Console.WriteLine();
