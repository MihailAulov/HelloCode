// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

﻿Console.Write("Введите число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number2 % 2 == 0)
{
    Console.WriteLine($"число {number2} чётное");  
}
else
{
    Console.WriteLine($"число {number2} нечётное");  
};