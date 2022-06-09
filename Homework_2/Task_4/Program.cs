// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int prompt(string message)
{
    Console.WriteLine(message);
    string text = Console.ReadLine();
    int number = int.Parse(text);
    return number;
}

int num = prompt("Input a number for day of the week");
if (num < 1 || num > 7) { Console.WriteLine("There is only 7 days in a week"); }
else
{
    if (num < 6) { Console.WriteLine("It is a workday"); }
    else { { Console.WriteLine("It is a weekend"); } }
}