// all even from 1 to N
Console.Write("Insert a number: ");
string N_str = Console.ReadLine();
int N = int.Parse(N_str);
int i = 2;
while (i<N-1){
    Console.Write($"{i}, ");
    i+=2;
}
Console.Write(i);