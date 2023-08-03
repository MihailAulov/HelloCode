int [] array = {1, 4, 33, 7, 57, 66, 74, 86};

int n = array.Length;
int find = 5;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
    }

    index++;
}
