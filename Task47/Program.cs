// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

int m = 3;
int n = 4;
double [,] result = new double[m, n];
void getArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
       for (int j = 0; j < n; j++)
       {
            result[i,j] = Convert.ToDouble(new Random().Next(-100,100)/10.0);
       }
    }
} 

void printArray(double[,] inArray)
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