int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) { result = arg2; }
    if (arg3 > result) { result = arg3; }
    return result;
}


int[] array = { 12, 24, 35, 74, 43, 23, 23, 1, 0 };
array[0] = 11;
Console.WriteLine(array[5]);
int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));

Console.WriteLine(max);