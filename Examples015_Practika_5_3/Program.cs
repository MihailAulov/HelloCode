/* Задайте одномерный массив из 123 случайных чисел.
   Найдите количество элементов массива, значения которых лежат в отрезке [10,99] */

int[] arr = GetRandomArray(123);
PrintArray(arr);
Console.WriteLine(FindNumInInterval(arr));

int FindNumInInterval(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 10 && array[i] <= 99)
        {
            count++;
        }
    }

    return count;
}

int[] GetRandomArray(int lenght)
{
    int[] result = new int[lenght];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(1, 1000);
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