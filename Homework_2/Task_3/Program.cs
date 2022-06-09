// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int power(int foundation, int power)
{
    if (power == 0) { return 1; }
    int counter = 1;
    int answer = 1;
    while (counter <= power)
    {
        answer = answer * foundation;
        counter++;
    }
    return answer;
}
int abs(int number)
{
    if (number < 0) { number = -number; }
    return number;
}
Console.WriteLine("Input any digit number (preferably more than a 1000)");
string numStr = Console.ReadLine();
int number = int.Parse(numStr);
if (number <= 99 && number >= -99) { Console.WriteLine("There is not enough digits"); }
else
{
    int remainder = abs(number);
    int digits = 0;
    while (remainder != 0)
    {
        digits++;
        remainder = remainder / 10;
    }
    int ThirdDigit = (number / power(10, digits - 3)) % 10;
    Console.WriteLine($"The third digit of {number} is {ThirdDigit}");
}