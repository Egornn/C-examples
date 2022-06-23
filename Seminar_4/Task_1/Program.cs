// Задача 1: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.


int digit (int number) //17
{
    int digits = 0;
    while (number > 0) // 17>0 || 1>0 || 0>0
    {
        digits++; // 0->1->2
        number = number / 10; //1 // 0
    }
    return digits;
}

Console.WriteLine("Введите число");
string numberstr = Console.ReadLine();
int number = int.Parse(numberstr);
Console.WriteLine($"Число знаков в {number} равно {digit(number)}");
