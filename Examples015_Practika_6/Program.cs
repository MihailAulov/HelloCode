/* Напишите программу,
которая перевернёт одномерный массив
(последний элемент будет на первом месте, а первый на последнем и т.д.) */

var arr = GetRandomArray(10);
PrintArray(arr);
ReverseArray(arr);
System.Console.WriteLine();
PrintArray(arr);

void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int tmp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = tmp;
    }
}

int[] GetRandomArray(int lenght)
{
    int[] result = new int[lenght];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(1, 100);
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