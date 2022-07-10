// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int sum ()
{
    int sum1 = 0;
    while (number>0)
    {
    sum1 = sum1 + number % 10;
    number /= 10; 
    }
    return sum1;
}
Console.WriteLine(sum());