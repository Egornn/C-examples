//Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int promptNumber (string message)
{
    Console.Write (message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int A = promptNumber("Input the base of power ");
int B = promptNumber("Input the power ");

int powerNat (int based, int power)
{
    int result = based;
    for (int i = 1; i<power; i++)
    {
       result=result*based;
    }
    return result;
}
Console.WriteLine($"{A} to the power {B} is {powerNat(A, B)}");