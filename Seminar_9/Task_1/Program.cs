//Натуральные от 1 до N рекурсией

void Recursive1ToN (int N)
{
    if (N<1) 
    {
        return;
    }
    else
    {
        
        Recursive1ToN(N-1);
        System.Console.Write($"{N}, ");
        
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
    
    int n = Prompt("Insert upper boundary");
    Recursive1ToN(n);

}



Solve();