/* Задача 57: Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
 информацию о том, сколько раз встречается
 элемент входных данных. */

 var array = GenArray();
 PrintArray(array);
 Console.WriteLine();   


 Dictionary<int, int> dict = new Dictionary<int, int>();
 for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(dict.ContainsKey(array[i,j]))
            {
                dict[array[i,j]]++; 
            }
            else
            {
                dict.TryAdd(array[i,j], 1);
            }
        }
    }

    foreach(var item in dict)
    {
        Console.WriteLine($"Элемент {item.Key} Количество {item.Value}");
    }


 int[,] GenArray(int rows = 5, int cols = 5)
{
    Random random = new Random();
    int[,] array = new int[rows, cols];
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = random.Next(1, 50);
        } 
    }
    return array;
}

void PrintArray(int[,] array)
{
   
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
    Console.WriteLine();
        
    }
}