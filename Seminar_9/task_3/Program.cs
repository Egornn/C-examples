// Сумма чисел 

int RecursiveDigitSum (int N)
{
    int num = 0;
    if (N == 0)
    { 
        return 0; 
    }
    else
    {
        num = N % 10 + RecursiveDigitSum(N / 10);
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
    int m = Prompt("Insert number to find sum of its digits");
    System.Console.WriteLine( RecursiveDigitSum(m));

}

Solve();

