// i times i up to N
using System.Text;
void RecursiveNRepeated(int N)
{
    if (N == 0)
    {
        return;
    }
    else
    {
        {
            string str = new StringBuilder($"{N} ".Length * N).Insert(0, $"{N} ", N).ToString();
            RecursiveNRepeated(N-1);
            System.Console.Write(str);            
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
    int N = Prompt("Insert the number");
    RecursiveNRepeated(N);

}



Solve();