// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

int Promt(string message)
{
    Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

//super Light version string as array

// //Light version - 5 digits
// bool CheckPalindprome(int input)
// {
//     int a1 = input / 10000;
//     int a5 = input % 10;
//     int a2 = input / 1000 - 10;
//     int a4 = input % 100 / 10;
//     Console.WriteLine($"a[1] = {a1}");
//     Console.WriteLine($"a[2] = {a2}");
//     Console.WriteLine($"a[4] = {a4}");
//     Console.WriteLine($"a[5] = {a5}");
//     if (a1 == a5 && a2 == a4) return true;
//     return false;
// } 

// semi-Hard Version - массивы

// hard Version
bool CheckPalindprome(int input)
{
    int i = 0; //сюда запишем сколько знаков в числе
    int a = input;
    while (a > 0) // цикл, который считает количество знаков
    {
        a = a / 10;
        i++;
    }

    while(input > 0 && i > 1)
    {
        // System.Console.WriteLine($"input = {input}");
        int aFirst = Convert.ToInt32(Math.Truncate(input / Math.Pow(10, i-1)));// первая цифра числа
        int aLast = input % 10; // последняя цифра чиасла
        // System.Console.WriteLine($"aFirst = {aFirst}");
        // System.Console.WriteLine($"aLast = {aLast}");
        if (aFirst != aLast)
        {
            return false;
        }
        input = Convert.ToInt32(input - (aFirst * Math.Pow(10, i-1)));
        input = input / 10;
        i = i - 2;
        // System.Console.WriteLine($"input = {input}");
        // System.Console.WriteLine($"i = {i}");
        // System.Console.WriteLine($"++++++++++++++++++++++++++++++++++++++++");
    }
    return true;
} 

int value = Promt("Введите число");
if (value > 9)
{
    if (CheckPalindprome(value)) Console.WriteLine($"Введенное значение {value} - палиндром ");
    else Console.WriteLine($"Введенное значение {value} - не палиндром ");
}
else
System.Console.WriteLine("введенное число меньше 10 -> всегда палиндром?");
