//Greater and leeser number out of 3
Console.Write("Insert the first number: ");
string first_str = Console.ReadLine();
Console.Write("Insert the second number: ");
string second_str = Console.ReadLine();
Console.Write("Insert the third number: ");
string third_str = Console.ReadLine();


double first = double.Parse(first_str);
double second = double.Parse(second_str);
double third = double.Parse(third_str);

double max = first;

if (second>max) {max=second;}
if (third>max) {max=third;}

Console.WriteLine($"The greater one is {max}");
