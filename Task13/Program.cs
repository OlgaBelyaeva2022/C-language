// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
string numText = Convert.ToString(num);

void showNum()
{
    if (numText.Length <= 2)
    {
        Console.WriteLine("третьей цифры нет");
    }
    else
    {
        Console.WriteLine(numText[2] + " - третья цифра заданного числа");
    }   
}
showNum();