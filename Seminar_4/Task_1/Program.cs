﻿// Задача 1: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// Задача 2: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

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
