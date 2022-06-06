//  Два числа, проверить является ли второе квадратом первого
Console.Write("Первое число: ");
string str_1 = Console.ReadLine();
Console.Write("Второе число: ");
string str_2 = Console.ReadLine();

int a = int.Parse(str_1);
int b = int.Parse(str_2);

if ((a * a == b) || (a == b * b))
{
    Console.WriteLine("Да, является квадратом");
}
else
{
    Console.WriteLine("Нет, не является квадратом");
}





// По номеру дня недели вывести название дня недели

Console.Write("Введите день ");
string day = Console.ReadLine();
int number = int.Parse(day);
    number = number % 7;
if (number == 0) {Console.WriteLine("Sunday");}
if (number == 1) {Console.WriteLine("Monday");}
if (number == 2) {Console.WriteLine("Tuesday");}
if (number == 3) {Console.WriteLine("Wednessday");}
if (number == 4) {Console.WriteLine("Thursday");}
if (number == 5) {Console.WriteLine("Friday");}
if (number == 6) {Console.WriteLine("Saturday");}
