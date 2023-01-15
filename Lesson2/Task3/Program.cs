// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

String CheckVacation(int dayOfWeek)
{
    string result = "Рабочий. Нет";
    if (dayOfWeek > 5) result = "Выходной. Да";
    return result;
}
Console.Write("Введите цифру, обозначающую день недели: ");
int i = Convert.ToInt32(Console.ReadLine());
if (i > 0 && i < 8) Console.WriteLine(CheckVacation(i));
else Console.WriteLine("Введена цифра, которая не может обозначать день недели");
