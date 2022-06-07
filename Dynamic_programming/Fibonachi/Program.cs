int fib(int n)
{
    //if (n == 1 ) { return 0; }
    int counter = 1;
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

int fibRec(int n){
    if (n<=2){return 1;}
    return (fibRec(n-1)+fibRec(n-2));
}
Console.WriteLine( fib(10));
Console.WriteLine( fibRec(10));
