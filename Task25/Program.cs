// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число А");
double A = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите число В");
double B = Convert.ToDouble(Console.ReadLine());

//double square (int x, int y)
//{
//    double square = Math.Pow(A, B);
//    return square;
//}
//Console.WriteLine(square(A, B));

double result = 1;
for (double i=1; i<=B; i++)
{
    result = result*Math.Pow(A, B);
    break; 
}
Console.WriteLine("{0} ^ {1} = {2}", A, B, result);
