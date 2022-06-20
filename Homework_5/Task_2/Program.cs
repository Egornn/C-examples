// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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
int SumOfOddPos (int [] array)
{
    int result=0;
    for (int i=0; i<array.Length; i=i+2)
    result=result+array[i];
    return result;
}

int len = prompt("Insert the length of the array: ");
int min = prompt("Insert the bottom bound of the array: ");
int max = prompt("Insert the upper bound the array: ");
int [] myarray = RandomArray (len, min, max);
PrintArray(myarray);
Console.WriteLine($"The total sum of numbers on odd position in the array is {SumOfOddPos(myarray)}");