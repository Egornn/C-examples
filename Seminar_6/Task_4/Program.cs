// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
void PrintArray (int [] array)
{
    for (int i=0; i<array.Length-1; i++)
    {
        Console.Write(array[i]+", ");
    }
    Console.WriteLine(array[array.Length-1]);
}

int [] PrintFibb (int N)
{   int [] array = new int [N];
    if (N==1) {return array;}
    
    array[0]=0;
    array[1]=1;
    for (int i=2; i<N;i++)
    {
        array[i]=array[i-2]+array[i-1];
    }
    return array;
}

PrintArray(PrintFibb(10));