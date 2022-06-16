// Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
int prompt (string message)
{
    Console.Write (message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int size = prompt("Введите число элементов массива: ");
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

int [] RandomArrayF (int[] array)
{
    for (int i=0; i<array.Length;i++)
        {
        k= new Random().Next(0,2);
        array[i]=k;
        }
    return array;
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
//PrintArray(array);
RandomArray01(array);
PrintArray(array);
PrintArray(RandomArrayF(array));