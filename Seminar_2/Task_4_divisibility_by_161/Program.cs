int prompt(string message)
{
    System.Console.Write(message);
    string numStr = Console.ReadLine();
    int num = int.Parse(numStr);
    return num;
}

int num = prompt("Input: ");

if (num % 7 == 0 && num % 23 == 0)
{
    Console.WriteLine("Divisible by 23 and 7");
}
else
{
    Console.WriteLine("Indivisible by 23 and 7");
}