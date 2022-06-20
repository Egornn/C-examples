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
string elstr =Console.ReadLine();
int el = int.Parse(elstr);
int [] array=initArray (el,0,123);
Console.WriteLine($"Число элементов в промежутке (10, 99) в случайном массиве из {el} элементов - {search2digit(array)}");