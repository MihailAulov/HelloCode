// Напишите программу, которая выводит случайноу число из отрезка [10, 99] и показывает наибольщую цифру числа .

int randomNumber = new Random().Next(10, 100);
int num1 = randomNumber % 10;
int num2 = randomNumber / 10; 

System.Console.WriteLine($"Выбрано число: {randomNumber}"); 
// Строковая интерполяция, удобная штука заменяет: ("Выбрано число: " + randomNumber)
System.Console.Write("Максимальная цифра числа: ");
System.Console.WriteLine(num1 > num2 ? num1 : num2);
