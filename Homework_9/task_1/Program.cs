// Even from M to N
void RecursiveMToN (int M, int N )
{
    if (N<M) 
    {
        return;
    }
    else
    {
        {
            if (M % 2 == 0)
            {
                System.Console.Write($"{M}, ");
            }
            RecursiveMToN(M + 1, N);
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
    int m = Prompt("Insert bottom boundary");
    int n = Prompt("Insert upper boundary");
    RecursiveMToN(m,n);

}



Solve();
