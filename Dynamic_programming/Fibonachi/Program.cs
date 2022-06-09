int fib(int n)
{

    if (n == 1 ) { return 0; }
    int counter = 2;
    int FibonacciPrevious = 0;
    int FibonacciCurrent = 1;
    int temp =0;
    while (counter < n)
    {
        temp=FibonacciCurrent;
        FibonacciCurrent=FibonacciCurrent+FibonacciPrevious;
        FibonacciPrevious=temp;
        counter++;
    }
    return FibonacciCurrent;
}

int fibRec(int n)
{
    if (n <= 2) { return 1; }
    return (fibRec(n - 1) + fibRec(n - 2));
}

int FibTimeEff(int n)
{
    if (n <= 2) { return 1; }
    int[] array = new int[n];
    array[0] = 1;
    array[1] = 1;
    int index = 2;
    while (index < n)
    {
        array[index] = array[index - 1] + array[index - 2];
        index++;
    }
    return array[n - 1];
}

int FibHashEquivalent(int n, Dictionary<int, int> memo = new Dictionary<int, int> (new memo { [1] = 1, [2] = 1}))
{   //if (memo==0){memo= new Dictionary<int, int>();}
   memo.Add(1, 1);
   memo.Add(2, 1);
   if (memo.ContainsKey(n)) { return memo[n]; }
   else
   {
       memo[n] = FibHashEquivalent(n - 1,memo) + FibHashEquivalent(n - 2,memo);
   }
}

Console.WriteLine(fib(9));
Console.WriteLine(fibRec(10));
Console.WriteLine(FibTimeEff(11));
//Console.WriteLine(FibHashEquivalent(12));
Console.WriteLine( fib(10));