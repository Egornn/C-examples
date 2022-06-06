// Absolute value
Console.Write("Number to get absolute: ");
string number_str = Console.ReadLine();
double number = double.Parse(number_str);
if (number < 0) { number = -number; }
Console.WriteLine($"Absolute value of {number_str} is {number}");
// Inverse

Console.Write("Number to get inverse: ");
string inverse_str = Console.ReadLine();
double inverse = double.Parse(inverse_str);
inverse = 1 / inverse;
Console.WriteLine($"The inverse of a {inverse_str} is {inverse}");

