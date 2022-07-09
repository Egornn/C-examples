// Проверка на простое


string RecursiveIfPrime(int N, int startingFrom)
{
    if (Math.Sqrt(N)< startingFrom)
    {
        return "it's Prime";
    }
    else
    {
        if (N % startingFrom ==0)
        {
            return "Not prime";
        }
        else
        {
            return RecursiveIfPrime(N, startingFrom + 1);
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
    int m = 0;
    while (m<1)
    {
        m= Prompt("Insert the possitive number to check if Prime");
    }
    int n = 2; //least possible prime
    System.Console.WriteLine( RecursiveIfPrime(m,n));

}

Solve();

