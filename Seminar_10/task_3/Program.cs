// Задача 3: Дано натуральное число N. Выведите все его цифры по одной, в обратном порядке, разделяя их пробелами или новыми строками.

void RecursiveNReversed (int N)
{
    if (N==0) 
    {
            System.Console.WriteLine();        
    }
    else
    {
        {
            Console.Write($"{N%10} ");
            RecursiveNReversed(N/10);
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
    RecursiveNReversed(N);

}



Solve();