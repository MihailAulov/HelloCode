// НАпишите программу, которая принимает на вход число (A) и выдаёт сумму чисел от 1 до A.

int GetSumFrom1ToN(int a)
{
    int result = 0;
    int count = 0;

    while (count <= a)
    {
       result += count;
       count ++;
    }
    
    return result;
}