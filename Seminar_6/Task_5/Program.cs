//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

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

int [] CopyArray (int [] array)
{
    int i =0;
    int [] copy = new int [array.Length];
    foreach (int element in array)
    {
        PrintArray(copy);
        copy[i]=element;
        
        i++;
    }
    return copy;
}

int [] newarray = CreateArray(7, 34, 50);
PrintArray (newarray);
int [] copy= CopyArray(newarray);
PrintArray (copy);

