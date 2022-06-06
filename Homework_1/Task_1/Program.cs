//Greater and leeser number out of 2
Console.Write("Insert the first number: ");
string first_str = Console.ReadLine();
Console.Write("Insert the second number: ");
string second_str = Console.ReadLine();

double first = double.Parse(first_str);
double second = double.Parse(second_str);

if (first > second) { Console.WriteLine($"The greater one is {first} and the lesser one is {second}"); }
else { Console.WriteLine($"The greater one is {second} and the lesser one is {first}"); }
