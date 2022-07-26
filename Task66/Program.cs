// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int GetResult (int m, int n)
{
    if (m > n)
    {
        return 0;
    }
    else
    {
        return m + GetResult(m + 1 , n);
    }
}
Console.WriteLine(GetResult(1, 15));