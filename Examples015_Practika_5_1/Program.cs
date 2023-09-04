/* Напишиет программу замена элементов массива:
положительные элементы замените на соответствующие отрицательные, и наоборот. */

int[] arr = GetRandomArray(10);
PrintArray(arr);
PrintArray(ReplaseNum(arr));

int[] ReplaseNum(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }

    return array;
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