/* Задача 53: Задайте двумерный массив. 
Напишите программу, которая поменяет 
местами первую и последнюю строку массива. */

var array = GetArray();
PrintArray(array);
System.Console.WriteLine();
ChangRows(array);
PrintArray(array);




void ChangRows(int[,] array)
{
    int lastRow = array.GetLength(0) - 1;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int temp = array[lastRow, i];
        array[lastRow, i] = array[0, i];
        array[0, i] = temp;
    }
}

int[,] GetArray(int rows = 5, int columns = 6)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = i + j;
        }

    }
    return array;

}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();

    }
}

/* int [,] threeFor = GetArray();
PrintArray(threeFor); */