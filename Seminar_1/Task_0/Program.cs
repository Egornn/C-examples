// Takes number, output its square

Console.Write ("Number to square: ");
string number = Console.ReadLine();
double answer = double.Parse(number);
answer = answer * answer;
Console.WriteLine("Square of your number is " + answer);