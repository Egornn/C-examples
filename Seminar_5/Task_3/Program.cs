int[] initArray (int len, int min, int max)
{
    Random rnd = new Random();
    int[] array = new int [len];
    for (int i =0; i<len; i++)
    {
        array[i]= new Random().Next(min, max+1);
    }
    return array;
}

int search2digit (int [] array)
{
    int result =0;
    for (int i = 0; i< array.Length;i++)
    {
        if (array[i]>=10&&array[i]<=99) result++;
    }
    return result;
}

int [] array=initArray (123,0,123);
Console.WriteLine(search2digit(array));