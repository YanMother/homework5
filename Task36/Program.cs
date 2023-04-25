﻿/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях. */ 

using static System.Console;
Clear();
Write("Введите размер массива: ");
int length = int.Parse(ReadLine()!);
Write("Введите минимальное значение массива: ");
int min = int.Parse(ReadLine()!);
Write("Введите максимальное значение массива: ");
int max = int.Parse(ReadLine()!);
int[] Array = GetArray(length, min, max);
WriteLine($"[{string.Join(", ", Array)}]");
FindOdd(Array);

int[] GetArray(int size, int minValue, int maxValue)
{
     Random rnd = new Random();
     int[] result = new int[size];
     for(int i = 1; i < result.Length; i++)
     {
          result[i] = rnd.Next(minValue, maxValue + 1);       
     }
     return result;
}

void FindOdd(int[] MyArray)
{
      int odd=0;
      for (int i = 1; i < MyArray.Length; i=i+2)
      {
        odd=odd+MyArray[i];
      }
      WriteLine($"Сумма чисел на нечетных позициях {odd}");
}
