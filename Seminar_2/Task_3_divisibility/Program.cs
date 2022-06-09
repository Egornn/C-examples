System.Console.WriteLine("Input Divider and Divisor");
string DividerStr = Console.ReadLine();
string DivisorStr = Console.ReadLine();
int divider = int.Parse(DividerStr);
int divisor = int.Parse(DivisorStr);

if (divisor % divider)
{
    console.WriteLine("Divisible");
}
else
{
    console.WriteLine($"Remainder is {divisor % divider} ");
}