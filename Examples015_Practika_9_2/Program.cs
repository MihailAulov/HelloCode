/* Задача 69. Напишите программу которая
на вход принимает два числа A и B, и возводит
число A в целую степень B, с помощью рекурсии. */

System.Console.WriteLine(Pow(5, -7));

double Pow(double num, double rank)
{
    if (rank == 0)
    {
        return 1;
    }
    if (rank == 1)
    {
        return num;
    }
    if(rank < 0)
    {
        return 1 / (num * Pow(num, rank +1));
    }

    return num * Pow(num, rank - 1);
}