//  N чисел, для которых каждое следующее равно сумме двух предыдущих.


void RecursiveFibonacciMToN (int firstN, int secondN, int number )
{
    if (number==2) 
    {
        System.Console.WriteLine($"{firstN}, {secondN}.");
    }
    else
    {
        {
            
            System.Console.Write($"{firstN}, ");
            RecursiveFibonacciMToN(secondN, firstN+secondN, number-1);
            
        }
    }
}

int Prompt (string console)
{
    System.Console.WriteLine(console);
    string numberStr = Console.ReadLine();
    return int.Parse(numberStr);
}

void Solve()
{
    int first = Prompt("Insert first number");
    int second = Prompt("Insert second number");
    int howMany = Prompt("How many numbers do you want? ");
    RecursiveFibonacciMToN(first,second,howMany);

}



Solve();