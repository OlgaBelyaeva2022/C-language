Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2 & num1 > num3)
{
    Console.Write("max = ");
    Console.WriteLine(num1);
}
else
{
    if (num2 > num1 & num2 > num3)
    {
    Console.Write("max = ");
    Console.WriteLine(num2);
    }
    else
    {
    Console.Write("max = ");
    Console.WriteLine(num3);    
    }
}
