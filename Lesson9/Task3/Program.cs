// Задача 3: Напишите программу вычисления   с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AnkermanFunction(int m, int n)
{
    if (m > 0 && n > 0) return AnkermanFunction(m-1, AnkermanFunction(m, n-1));
    if (m > 0 && n == 0) return AnkermanFunction(m-1, 1);
    else return n+1;
}

int m = 3;
int n = 2;
System.Console.Write($"m = {m}; n = {n} -> A(m,n) = {AnkermanFunction(m, n)}");