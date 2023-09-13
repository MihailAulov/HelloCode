/* Задача 63. Задайте значение N. 
Задайте программу которая выдаёт 
все натуральные числа в 
промежутке от 1 до N.  */

// Задача 63 и по сути 65

System.Console.WriteLine(PrintNumbers(1, 1000000));

 string PrintNumbers(int start, int end)
 {
    if (start == end)
    {
        return start.ToString();
    }
    return start + " " + PrintNumbers(start + 1, end);
 }

/* Задача 65. Задайте значение M и N.
Напишиет программу которая выведет
все натуральные числа в промежутке от M до N. */




