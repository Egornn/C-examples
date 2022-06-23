// See https://aka.ms/new-console-template for more information
int [] CreateArray (int len, int min, int max)
{
    var array = new int [len];
    var rnd = new Random();
    for (int i=0; i<len;i++)
    {
        array[i]=rnd.Next(min, max+1);
    }
    return array;
} 
void PrintArray (int [] array)
{
    for (int i=0; i<array.Length-1; i++)
    {
        Console.Write(array[i]+", ");
    }
    Console.WriteLine(array[array.Length-1]);
}
int [] InverseArray (int [] array)
{
    int [] reverse = new int [array.Length];
    for (int i = 0; i<(array.Length);i++)
    {
        reverse[i]=array[array.Length-1-i];

    }
    return reverse;
}


int [] NewArray = CreateArray(4,1,20);
PrintArray (NewArray);
PrintArray (InverseArray(NewArray));