System.Console.Write("Input: ");
string numStr = Console.ReadLine();
int num = int.Parse(numStr);
if (num % 7 == 0 && num % 23 == 0)
{
    Console.WriteLine("Divisible by 23 and 7");
}
else
{
    Console.WriteLine("Indivisible by 23 and 7");
}