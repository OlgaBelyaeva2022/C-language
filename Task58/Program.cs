// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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
int[,] array2 = getArray(rows, columns);
printArray(array2);
Console.WriteLine();

int[,] resultArray = new int[rows,columns];
for (int i = 0; i < resultArray.GetLength(0); i++)
{
    for (int j = 0; j < resultArray.GetLength(1); j++)
    {
        resultArray[i,j] = 0;
        for (int k = 0; k < resultArray.GetLength(1); k++)
        {
            resultArray[i, j] += array1[i, k] * array2[k, j];
        }
    }
}
printArray(resultArray);

