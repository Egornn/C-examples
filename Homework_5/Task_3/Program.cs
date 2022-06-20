//Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


int prompt (string message)
{
    Console.Write (message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
double promptD (string message)
{
    Console.Write (message);
    double number = double.Parse(Console.ReadLine());
    return number;
}
double [] RandomArray (int len, double min, double max)
{
    
    double [] RngArray = new double [len];
    for (int i =0; i<RngArray.Length;i++)
    RngArray[i]= new Random().NextDouble()*(max-min)+min;
    return RngArray;
}
void PrintArray (double [] array)
{
    Console.Write("[");
    for (int i=0; i<array.Length-1; i++)
    {
        Console.Write(array[i]+", ");
    }
    Console.WriteLine(array[array.Length-1]+"]");
}
double MinMaxDiff (double [] array)
{
    double result=0;
    double max=array[0];
    double min=array[0];
    for (int i=0; i<array.Length; i++)
    {
        if (array[i]>max){max=array[i];}
        if (array[i]<min){min=array[i];}
    }
    result =max-min;
    return result;
}

int len = prompt("Insert the length of the array: ");
double min = promptD("Insert the bottom bound of the array: ");
double max = promptD("Insert the upper bound the array: ");
double [] myarray = RandomArray (len, min, max);
PrintArray(myarray);
Console.WriteLine($"The difference between Maximum and Minimum in the array is {MinMaxDiff(myarray)}");