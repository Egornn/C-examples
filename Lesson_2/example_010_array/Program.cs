
int[] array = { 1, 21, 32, 43, 54, 564, 45, 4, 4 };

int n = array.Length;
int find = 4;
int index = 0;

while (index < n)
{
    if (array[index] == find) { Console.WriteLine(array[index]); }
    index++;
}