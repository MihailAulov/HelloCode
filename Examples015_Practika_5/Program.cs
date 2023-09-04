﻿/* Задайте массив из 12 элементов, заполненых случайными числами из промежутка [-9,9].
Найдите сумму отрицательных и положительных элементов массива.
Например в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
сумма отрицательных равна -20. */

int[] arr = GetRandomArray(10);
PrintArray(arr);
Console.WriteLine(GetSumMoreZero(arr));
Console.WriteLine(GetSumLessZero(arr));

int GetSumMoreZero(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 0)
        {
            result += arr[i];
        }
    }

    return result;
}

int GetSumLessZero(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
        {
            result += arr[i];
        }
    }

    return result;
}

int[] GetRandomArray(int lenght)
{
    int[] result = new int[lenght];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(-20, 21);
    }

    return result;
}

void PrintArray(int[] array)
{
    foreach (int item in array) 
    {
        Console.Write(item + "  ");
    }

    Console.WriteLine();
}