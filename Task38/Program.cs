// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double[] getArray(int n)
{
    double[] arr = new double[n];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToDouble(new Random().Next(-100,100)/10.0);
    }
    return arr;
}
double [] array = getArray(4);
Console.WriteLine(string.Join(",  ", array));

double min = array[0];
double max = array[0];
for (int j = 0; j < array.Length; j++)
{
    if (array[j] > max) max = array[j];
    if (array[j] < min) min = array[j];
}
double diff = max - min;
Console.WriteLine("Разница между макс. и мин. элементами массива" + " = " + diff);
