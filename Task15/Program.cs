// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Напишите цифру от 1 до 7");
int day = Convert.ToInt32(Console.ReadLine());

string dayOfWeek ()
{
    if (day == 6 || day == 7)
    {
    return ("этот день выходной");
    }
    else
    {
    return ("этот день не является выходным");
    }
}
Console.WriteLine(dayOfWeek());