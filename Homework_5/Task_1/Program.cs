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
    RngArray[i]= new Random().Next(min,max);
    return RngArray;
}
