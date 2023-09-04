/* Напишите прогармму,
которая принимает на вход три числа
и проверяет, может ли существоавать
треугольник со сторонами такой длины. */

// Решение первое
/* System.Console.WriteLine(IsTriangle(1, 1, 9));

bool IsTriangle(int stA, int stB, int stC)
{
    return (((stA + stB) > stC) && ((stB + stC) > stA) && ((stC + stA) > stB));
} */

// Второе решение - лямда выражение

/* var isTriangle = (int stA, int stB, int stC) =>
     (((stA + stB) > stC) && ((stB + stC) > stA) && ((stC + stA) > stB));
    
System.Console.WriteLine(isTriangle(1, 1, 9)); */ 


// Углубленое изучение

var persons = new List <Person> {
    new Person { 
        Id = 1, 
        Name = "Dima"
    },
    new Person { 
        Id = 2, 
        Name = "Misha"
    },
};

System.Console.WriteLine(persons.Where(p => p.Id == 2).FirstOrDefault().Name);

public class Person
{
    public int Id { get; set;}
    public string Name { get; set;}
}
