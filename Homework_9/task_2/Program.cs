// Sum from M to N
int RecursiveMToNSum (int M, int N )
{
    int total = 0;
    if (N<M) 
    {
        return 0;
    }
    else
    {
        {
            total=M+RecursiveMToNSum(M + 1, N);
            return total;
        
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
    System.Console.WriteLine(RecursiveMToNSum(m,n));

}



Solve();
