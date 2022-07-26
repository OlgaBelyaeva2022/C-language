// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

string Numbers (int m, int n)
{
    if (m == n)
    {
        return n.ToString();
    }
    return m.ToString() + " " + Numbers(m += 1, n);
}
Console.WriteLine(Numbers(5, 15));
