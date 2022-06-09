// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int prompt(string message)
{
    Console.WriteLine(message);
    string text = Console.ReadLine();
    int number = int.Parse(text);
    return number;
}

int num = prompt("Input 3 digit number");
while (num < 100 || num > 999)
{
    Console.WriteLine("It's not a 3 digit number");
    num = prompt("Input 3 digit number");
}
Console.WriteLine($"The second digit is {(num % 100) / 10}");