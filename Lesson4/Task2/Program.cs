// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Promt(string message)
{
    Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int MakeSum(int number)
{
    int result = 0;
    while(number > 0)
    {
        result += number % 10; 
        number /= 10;
    }
    return result;
}

int number = Promt("Введите число");
System.Console.WriteLine($"Введено число {number}. сумма цифр в числе = {MakeSum(number)}");