// // Задача 4: Найдите произведение пар чисел в одномерном массиве. 
// //Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

// int [] InitArray (int len, int min, int max)
// {
//     Random rnd = new Random();
//     int[] array = new int [len];
//     for (int i =0; i<array.Length; i++)
//     {
//         array[i]= rnd.Next(min, max+1);
//     }
//     return array;
// }
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
    int len=array.Length;
    int [] result = new int [(len+1)/2];
        for (int i =0; i<(len)/2;i++)
    {
        result[i]=array[i]*array[len-1-i];
    }
    if (len % 2==1) result[(len)/2]=array[(len)/2];
    
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

// int[] ProizvPar(int[] array)
// {
//     int[] rez = new int[array.Length/2];
//    for(int i = 0; i < (array.Length/2); i++)
// {
//    rez[i]= array[i] * array[array.Length - i -1];
// }
// return rez;
// }
// int[] myArray = InitArray(5, 1, 10);
// PrintArray(myArray);
// int[] myArray2 = ProizvPar(myArray);
// PrintArray(myArray2);