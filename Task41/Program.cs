﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
Console.WriteLine("Введите несколько чисел через пробел");
int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
  if (numbers[i] > 0)
    {
        count = count + 1;
    }  
}

Console.WriteLine($"Кол-во элементов > 0: {count}");