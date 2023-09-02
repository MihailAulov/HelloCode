//Напишите программу которая принимает на вход число и выдает количество цифр в числе.

Console.WriteLine(GetLenghtNum(48736));

int GetLenghtNum(int num)
{
    int len = default; // так же = 0;
// System.Console.WriteLine(len); // проверили число присвоения
    while(num > 0)
    {
        len++;
        num /= 10;
    }
    
    return len;
}