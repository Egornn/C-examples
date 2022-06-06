// Вычислить куб
Console.Write("введите число ");
string str = Console.ReadLine();
double a = double.Parse(str);
double answer = Math.Pow(a, 3);
Console.WriteLine($"Число в кубе - {answer}");

// Получаем число N, выводим числа от -N до N

Console.Write("введите число ");
str = Console.ReadLine();
int N = int.Parse(str);
int i = Math.Min(-N, N);
while (i < Math.Max(N, -N))
{
    //Console.Write(i+", ");
    Console.Write($"{i}, ");
    //Console.WriteLine(i);


    i++;
    //i+=1;
    //i=i+1;
}
Console.Write(i + ".");