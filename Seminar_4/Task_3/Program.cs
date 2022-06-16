// Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
int size = 8;
int[] array = new int[size];
int k = 0;

void RandomArray01 (int[] array)
{
    for (int i=0; i<array.Length;i++)
        {
        k= new Random().Next(0,2);
        array[i]=k;
        }
}

void PrintArray (int [] array)
{
    Console.Write("[");
    for (int i=0; i<array.Length-1; i++)
    {
        Console.Write(array[i]+", ");
    }
    Console.WriteLine(array[array.Length-1]+"]");
}

RandomArray01(array);
PrintArray(array);
// wrong PrintArray(RandomArray01(array));