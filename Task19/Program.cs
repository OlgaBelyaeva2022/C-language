// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число");
int number  = Convert.ToInt32(Console.ReadLine());

string palindrome (int num)
{
    if (num/10000 == num%10 && (num/1000)%10 == (num%100)/10)
    {
        return "Число является палиндромом";
    }
    return "Число не является палиндромом";
}
Console.WriteLine(palindrome(number));