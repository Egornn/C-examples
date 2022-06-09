int RandomNum = new Random().Next(10, 100);
int FirstDigit = RandomNum / 10;
int SecondDigit = RandomNum % 10;

if (FirstDigit > SecondDigit)
{
    Console.WriteLine($"The bigger digit is {FirstDigit} and the number was {RandomNum}");
}
else
{
    Console.WriteLine($"The bigger digit is {SecondDigit} and the number was {RandomNum}");
}