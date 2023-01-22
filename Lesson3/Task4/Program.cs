// Напишите программу, которая выводит первые заданные элемента следующей последовательности: 
// -> 12
// 1 2 2 3 3 3 4 4 4 4 5 5

//add test ubuntu

int Promt(string message)
{
    Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

String Output(int i)
{
    int j = 1;
    int jstart=1;
    int counter = 0;
    String result = "";
    int number = 1;
    while (counter < i)
    {
        while (j > 0 && counter < i)
        {
        result = result + " " + number;
        j = j-1;
        counter++;
        }
        number++;
        j = jstart + 1;
        jstart++;
    }
    return result;
}
int usersNumber = Promt("Сколько чисел заданной последовательности будем писать?");
if (usersNumber > 0) System.Console.WriteLine(Output(usersNumber));
else System.Console.WriteLine("Данная последовательность не предполагает такого числа");