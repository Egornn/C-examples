//Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int prompt (string message)
{
    Console.Write (message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int [] RandomArray (int len, int min, int max)
{
    
    int [] RngArray = new int [len];
    for (int i =0; i<RngArray.Length;i++)
    RngArray[i]= new Random().Next(min,max+1);
    return RngArray;
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

int NumberOfEven (int [] array)
{
    int result=0;
    for (int i=0; i<array.Length; i++)
    if (array[i]%2==0) result++;
    return result;
}

int len = prompt("Insert the length of the array: ");
int min = prompt("Insert the bottom bound of the array: ");
int max = prompt("Insert the upper bound the array: ");

int [] myarray = RandomArray (len, min, max);
PrintArray(myarray);
Console.WriteLine($"The total number of even number in the array is {NumberOfEven(myarray)}");