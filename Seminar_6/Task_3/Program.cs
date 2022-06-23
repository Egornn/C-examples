// Задача 2: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10
// 9  -> 1001 -> 1*1 + 0*2 + 0*2^2 + 1 * 2^3
//123 -> 3*1 + 2*10 + 1 *100 (10^2)

int prompt (string message)
{
    Console.Write (message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void DecToBin (int NumberBase10)
{
    int digits = Convert.ToInt32(Math.Log2(NumberBase10)+1); //log_2 (45)= 5.491853... 32 -> 100000

    int [] binary = new int [digits];
    //int binary = 0;
    int i =0;
    while (NumberBase10 > 0)
    {
        binary [binary.Length-1-i]=NumberBase10%2;
        NumberBase10 = NumberBase10/2;
        Console.WriteLine(i+" "+binary[binary.Length-1-i]);
        i++;
    }
    binary[0]=NumberBase10; // [1, 0, 1, 1, 0, 1]
    foreach (int element in binary)
    {
        Console.Write(element);
    }
      Console.WriteLine();
}
int DecToBinNoArr (int NumberBase10)
{
    //int digits = Convert.ToInt32(Math.Log2(NumberBase10)+1);

    int binary =0;
    int i =0;
    //for (int i =0; i<=digits; i++)
    while (NumberBase10>0)
    {
        binary=binary + (NumberBase10%2) * Convert.ToInt32(Math.Pow(10,i)); // 0+ 1*10^0=1 -> 1+ 0*10^1=1 -> 1+1*10^2=101 -> 101+1*10^3=1101 -> 1101 + 0*10^4 = 1101 -> 1101 +1*10^5 = 101101
        NumberBase10=NumberBase10/2;                                        // 45/2 = 22  -> 22/2 =11     -> 11/2 = 5     -> 5/2 = 2         -> 2/2 =1               -> 1/2 = 0
        i++;
    }
    return binary; // 101101
    


}
int Decimal =prompt("Введите число для преобразования в двоичный вид ");
DecToBin(Decimal);

Console.WriteLine (DecToBinNoArr(Decimal));