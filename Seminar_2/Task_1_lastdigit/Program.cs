

Console.WriteLine("Input 3 digit number");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);


while (number < 100 || number >= 1000)
{
    Console.WriteLine("Число не трехзначное. Повторите ввод");
    numberStr = Console.ReadLine();
    number = int.Parse(numberStr);
}

int LastDigit = number % 10;
Console.WriteLine($"Last digit is {LastDigit}");

