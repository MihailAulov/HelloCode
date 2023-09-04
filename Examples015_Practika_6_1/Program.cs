/* Напишите прогармму,
которая принимает на вход три числа
и проверяет, может ли существоавать
треугольник со сторонами такой длины. */


System.Console.WriteLine(IsTriangle(1, 1, 9));

bool IsTriangle(int stA, int stB, int stC)
{
    return (((stA + stB) > stC) && ((stB + stC) > stA) && ((stC + stA) > stB));
}

// Второе решение - лямда выражение

/* var isTriangle = (int stA, int stB, int stC) =>
     (((stA + stB) > stC) && ((stB + stC) > stA) && ((stC + stA) > stB));
    
System.Console.WriteLine(isTriangle(1, 1, 9)); */ 
