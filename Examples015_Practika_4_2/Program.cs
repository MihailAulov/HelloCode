// Напишите программу которая выводит массив из 8 элементов, заполненных нулями в случайном порядке.

PrintArray(GenerateArray(10));

int[] GenerateArray(int lenght)
{
    int[] result = new int[lenght];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(0, 2);
    }

    return result;
}

void PrintArray(int[] array)
{
    foreach (int i in array) // перебирает непосредственно значение элементов массива
    {
        Console.Write($"{i} ");
    }
}