// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] getArray(int mLocal, int nLocal)
{
    int[,] result = new int[mLocal, nLocal];
    for (int i = 0; i < mLocal; i++)
    {
        for (int j = 0; j < nLocal; j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}

void printArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int rows = 4;
int columns = 4;
int[,] array1 = getArray(rows, columns);
printArray(array1);
Console.WriteLine();

int minRowSum = int.MaxValue, indexMinRow = 0;
for (int i = 0; i < array1.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array1.GetLength(1); j++)
    {
        sum += array1[i,j]; 
    }
    Console.WriteLine($"Сумма элементов в строке = {sum}");
    if (sum < minRowSum)
    {
        minRowSum = sum;
        indexMinRow++;
    }
}
Console.WriteLine($"Наименьшая сумма элементов в строке {indexMinRow}");
