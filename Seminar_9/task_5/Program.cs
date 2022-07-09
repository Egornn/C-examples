// Is power of 2

string RecursiveIfPowerOftwo(double N, int B)
{
    
    if (N<=2)
    {
        if (N==2)    
        {
            return "Yes";
        }
        else
        {
            return "No";
        }
    }
    else
    {
        
        return RecursiveIfPowerOftwo(N/2, B);
    }
}

double Prompt (string console)
{
    System.Console.WriteLine(console);
    string numberStr = Console.ReadLine();
    return double.Parse(numberStr);
}

void Solve()
{
    double m = Prompt("Insert the number to check if its 2^k");
    int n = 2;
    System.Console.WriteLine( RecursiveIfPowerOftwo(m,n));

}

Solve();

