//Задача 3: Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран. Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах)
int promptNumber (string message)
{
    Console.Write (message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int [] RandomArray (int[] array, int rangeB, int rangeU)
{
    int rng = 0;
    for (int i=0; i<array.Length;i++)
        {
        rng= new Random().Next(rangeB,rangeU+1);
        array[i]=rng;
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


int size = promptNumber("input the size of the array: ");
int RangeB = promptNumber("input the lower bound of the array: ");
int RangeU = promptNumber("input the upper bound of the array: ");
int[] array = new int[size];
array=RandomArray(array,RangeB, RangeU);
PrintArray(array);

