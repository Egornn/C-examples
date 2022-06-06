// See https://aka.ms/new-console-template for more information
Console.WriteLine("Username");
string username = Console.ReadLine ();
if (username.ToLower() == "egor")
{
    Console.WriteLine("Hooray, it's Egor");
}
else 
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}