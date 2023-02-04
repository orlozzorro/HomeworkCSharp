// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, 
// y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
double Promt(string message)
{
    Console.Write($"{message} >");
    return Convert.ToDouble(Console.ReadLine());
}

string CheckValue(double b1, double k1, double b2, double k2)
{
    string result;
    if ((k1 == k2) && (b1 == b2)) result = "Прямые совпадают";
    else if (k1 == k2) result = "Прямые параллельны";
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        result = $"Прямые пересекаются в точке ({x}, {y})";
    }
    return result;
}

double b1 = Promt("Введите b1");
double k1 = Promt("Введите k1");
double b2 = Promt("Введите b2");
double k2 = Promt("Введите k2");

System.Console.WriteLine(CheckValue(b1, k1, b2, k2));

