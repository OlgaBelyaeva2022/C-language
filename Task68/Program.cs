// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29
 
 int GetResult (int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return GetResult(m - 1, 1);
    }
    return GetResult(m - 1, GetResult(m, n - 1));
}
Console.WriteLine(GetResult(3, 2));
