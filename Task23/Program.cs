// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());

void showCube ()
{
    Console.WriteLine("Число\tКуб");
    for (int i = 1; i <= N; i ++)
    {
        Console.WriteLine("{0}\t{1}", i, Math.Pow(i,3));
    }
}
showCube();