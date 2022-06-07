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

Console.WriteLine( fib(10));