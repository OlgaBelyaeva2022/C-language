// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите номер строки");
int pos1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int pos2 = Convert.ToInt32(Console.ReadLine());

int m = 3; // размер массива
int n = 4; // размер массива
int [,] result = new int[m, n];
void getArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
       for (int j = 0; j < n; j++)
       {
            result[i,j] = new Random().Next(1,11);
       }
    }
} 

void printArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
       for (int j = 0; j < inArray.GetLength(1); j++)
       {
            Console.Write($"{inArray[i,j]} ");
       } 
       Console.WriteLine();
    }
}

getArray(result);
printArray(result);

if (pos1 > result.GetLength(0) || pos2 > result.GetLength(1))
{
    Console.WriteLine("Такого значения нет");
}
else
{
    Console.WriteLine($"Значение элемента = {result[pos1-1,pos2-1]}");       
}
       


