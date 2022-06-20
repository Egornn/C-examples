// Задача 4: Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

int [] CreateArray (int len, int min, int max)
{
    Random rnd = new Random();
    int[] array = new int [len];
    for (int i =0; i<array.Length; i++)
    {
        array[i]= rnd.Next(min, max+1);
    }
    return array;
}

int [] MultPair (int [] array)
{
    int [] result = new int [(array.Length+1)/2];

    for (int i =0; i<(array.Length)/2;i++)
    {
        result[i]=array[i]*array[array.Length-1-i];
    }
    if (array.Length % 2==1){result[(array.Length)/2]=array[(array.Length)/2];}
    
    return result;
}

void PrintArray(int [] array )
{
    for (int i=0; i<array.Length;i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int prompt (string message)
{
    Console.Write (message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int len=prompt("Insert the length of an array ");
int min=prompt("Insert the lower bound of the array ");
int max=prompt("Insert the upper bound of the array ");

int [] myarray = CreateArray(len,min,max);
PrintArray(myarray);
PrintArray(MultPair(myarray));