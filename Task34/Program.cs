// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] getArray(int n)
{
    int[] arr = new int[n];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}

int [] array = getArray(4);
Console.WriteLine(string.Join(",", array));

int getResult(int[] array)
{
    int count = 0;
    for (int i=0; i < array.Length; i++) 
    {
        if (array[i]%2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Количество четных чисел в массиве" + "-" + getResult(array));
