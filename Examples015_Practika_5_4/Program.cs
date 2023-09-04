/*  Найдите произведение пар чисел в одномерном массиве. 
    Парой считается первый и последний элемент.
    Результат запишите в новом массиве. */

int[] arr = GetRandomArray(5);
PrintArray(arr);
int[] newArray = FindSumOfPairs(arr);
PrintArray(newArray);


int[] FindSumOfPairs(int[] array)
{
    int newSize = array.Length / 2;
    if(array.Length % 2 == 1)
    {
        newSize++;
    }
    int[] result = new int[newSize];

    for(int i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] * array[array.Length -1 - i];
    }

       if(array.Length % 2 == 1)
    {
        result[newSize - 1] = array[array.Length / 2];
    }

    return result;
}

int[] GetRandomArray(int lenght)
{
    int[] result = new int[lenght];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(1, 11);
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