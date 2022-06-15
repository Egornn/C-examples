// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N
int prompt(string msg)
{
    System.Console.WriteLine(msg);
    string N = System.Console.ReadLine(); 
    return int.Parse(N);
}
int powerx(int based, int power)
{
    int result=1;
    for (int i =0; i<power;i++)
    {
        result=result*based;
    }
    return result;
}
int N=prompt("Input N");
for (int i =1; i<N;i++)
{
    Console.Write($"{powerx(i,3)}, ");
}
Console.WriteLine (powerx(N,3)+".");