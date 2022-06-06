//Even test
Console.Write("Insert a number: ");
string number_str = Console.ReadLine();
int number = int.Parse(number_str);
if (number%2==0) {
    Console.WriteLine($"{number_str} is even");
}
else {
    
    Console.WriteLine($"{number_str} is odd");
}