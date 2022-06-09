// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
int prompt(string message)
{
    Console.WriteLine(message);
    string numStr = Console.ReadLine();
    int num = int.Parse(numStr);
    return num;
}
int number = prompt("Input a 3 digit number");
while (number <= 99 || number >= 1000)
{
    Console.WriteLine("Input is not a 3 digit number");
    number = prompt("Input a 3 digit number");
}
int mod = number / 100 * 10 + number % 10;

Console.WriteLine($"Without a second digit {number} is {mod}");
