//  Два числа, проверить является ли второе квадратом первого
Console.Write("Первое число: ");
string str_1 = Console.ReadLine();
Console.Write("Второе число: ");
string str_2 = Console.ReadLine();

int a = int.Parse(str_1);
int b = int.Parse(str_2);

if (a*a == b) {
    Console.WriteLine("Да, является квадратом");
}
else {
    if (a == b*b)
    { 
        Console.WriteLine("Да, является квадратом");
        }
        else{
            Console.WriteLine("Нет, не является квадратом");
        }
     
}




// По номеру дня недели вывести название дня недели

