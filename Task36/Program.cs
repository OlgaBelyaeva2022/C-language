// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] getArray(int n)
{
    int[] arr = new int[n];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-100, 101);
    }
    return arr;
}

int [] array = getArray(4);
Console.WriteLine(string.Join(",", array));

int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0) 
        {
        sum = sum + array[i];
        }
}
Console.WriteLine("Сумма элементов, стоящих на нечетных позициях" + " = " + sum);
