// A^B

int RecursiveAToPowerB(int A, int B)
{
    int num = 1;
    if (B == 0)
    {
        return 1;
    }
    else
    {
        num = A * RecursiveAToPowerB(A, B - 1);
        return num;
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
    int m = Prompt("Insert the base");
    int n = Prompt("Insert the power");
    System.Console.WriteLine( RecursiveAToPowerB(m,n));

}

Solve();

