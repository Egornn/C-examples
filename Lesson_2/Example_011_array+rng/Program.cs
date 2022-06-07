void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}

int IndexOf(int[] collection, int find)
{
    int position = -1;
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        if (collection[index] == find)
        {
            position = index;
            break;

        }
        //Console.Write("Position"+ position);
        //Console.Write(" Element "+ collection[index]);
        //Console.WriteLine(" index - "+ index);
        index++;
    }

    return position;
}
int[] array = new int[10];
int find = 1;
FillArray(array);
//PrintArray(array);
//int[] array2 = {6,2,7,6,1,9,8,9,7,7};
//array[2] = 4;
//array[3] = 4;
PrintArray(array);

Console.WriteLine($"Position of {find} is {IndexOf(array, find)} in random array");

//Console.WriteLine($"Position of {find} is {IndexOf(array2, find)} in random array");

//PrintArray(array);
