// Takes number, output its square

Console.Write("Number to square: ");
string number = Console.ReadLine();
double answer = double.Parse(number);
answer = answer * answer;
//Console.WriteLine("Square of your number is " + answer);
Console.WriteLine($"Square of {number} is {answer}");
if (answer >= 25)
{
    Console.WriteLine("Result is grater or equal than 25");
}
else
{
    Console.WriteLine("Result is less than 25");
}