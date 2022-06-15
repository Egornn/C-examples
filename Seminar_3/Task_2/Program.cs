// Get two dots in space return the distance
string prompt(string msg)
{
    System.Console.WriteLine(msg);
    string coordinates = System.Console.ReadLine(); 
    return coordinates;
}

string coordinates1 = prompt ("Input coorinates in the form x1, y1");
//string coordinates2 = prompt ("Input coorinates in the form x2, y2");

int comma = 0;
int length = coordinates1.Length;
for (int counter = 0; counter <  length; counter++ )
{
    if (coordinates1[counter] == ',') 
    {
        comma=counter;
    }
    
}
Console.WriteLine(comma);