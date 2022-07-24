// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
//добавляя индексы каждого элемента. Массив размером 2 x 2 x 2
//12(0,0,0) 22(0,0,1)
//45(1,0,0) 53(1,0,1)

int countNums = 89;

int[,,] Create3DMassive(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    int[] numbers = new int[countNums];
    int num = 10;
    for (int i = 0; i < numbers.Length; i++) numbers[i] = num ++;

    for (int i = 0; i < numbers.Length; i++)
    {
        int randomInd = new Random().Next(0, numbers.Length);
        int temp = numbers[i];
        numbers[i] = numbers[randomInd];
        numbers[randomInd] = temp;
    }

    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = numbers[index++];
            }
        }
    }
    return array;
}

int x = 2;
int y = 2;
int z = 2; 
int[,,] result = Create3DMassive(x, y, z);

for (int i = 0; i < result.GetLength(0); i++)
{
    for (int j = 0; j < result.GetLength(1); j++)
    {
        for (int k = 0; k < result.GetLength(2); k++)
        {
            Console.WriteLine($"[{i},{j},{k}] - {result[i, j, k]}");
        }
        Console.WriteLine();
    }
}

