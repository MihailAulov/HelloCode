// Напишите прогармму, которая принимает на вход два числа проверяет, является ли одно числа квадратом другого.

int num1 = 4;
int num2 = 17;

if (Math.Pow(num1, 2) == num2) // Возводит число в степень Math.Pow(число, степень)
{
    System.Console.WriteLine("Число является квадратом второго числа");
    return;
}

if (Math.Pow(num2, 2) == num1)
{
    System.Console.WriteLine("Число является квадратом второго числа");
    return;
}

else
{
        System.Console.WriteLine("Число не является квадратом второго числа");
}