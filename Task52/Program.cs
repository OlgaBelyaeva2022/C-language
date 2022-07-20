// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int m = 3;
int n = 4;
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

void findAvrValue(int[,] newArray)
{
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < newArray.GetLength(0); i++)
        {
            sum += newArray[i,j];
        }
        Console.WriteLine($"Среднее арифметическое элементов в столбце = {sum/newArray.GetLength(0)}");
    }
}

getArray(result);
printArray(result);
findAvrValue(result);