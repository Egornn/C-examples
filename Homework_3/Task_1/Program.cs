//Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
string prompt(string msg)
{
    System.Console.WriteLine(msg);
    string number = System.Console.ReadLine(); 
    return number;
}
string number=prompt("Select a 5-digit number");

if (number.Length != 5)
{
    Console.WriteLine($"{number} is not a 5-digit number");
}
else
{
    if (number[0]  == number[4]&& number[1]  == number[3] ) 
    {
        Console.WriteLine($"{number} is a palindrome");
    }
    else
    {
        Console.WriteLine($"{number} is not a palindrome");
    }
}

