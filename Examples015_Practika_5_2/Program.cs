// Задайте массив. Напишите прогармму, которая определяет, присутствует ли заданное число в массиве.

int[] arr = GetRandomArray(10);
PrintArray(arr);
System.Console.WriteLine(FindNum(10, arr));

bool FindNum(int num, int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == num)
        {
            return true;
        }
    }

    return false;
}

int[] GetRandomArray(int lenght)
{
    int[] result = new int[lenght];

    for(int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(-20, 21);
    }

    return result;
}

void PrintArray(int[] array)
{
    foreach(int item in array) 
    {
        Console.Write(item + "  ");
    }

    Console.WriteLine();
}