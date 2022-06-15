// Get two dots in space return the distance
string prompt(string msg)
{
    System.Console.WriteLine(msg);
    string coordinates = System.Console.ReadLine(); 
    return coordinates;
}

string coordinates1 = prompt ("Input coorinates in the form x1, y1");
//string coordinates2 = prompt ("Input coorinates in the form x2, y2");

double Coordinate(string coordinates,string axis)
{
    int comma = 0;
    double result = 0;
    int length = coordinates.Length;
    for (int counter = 0; counter <  length; counter++ )
    {
        if (coordinates1[counter] == ',') 
        {
            comma=counter;
        }
    }
    if (axis == "1") 
    {
        result = double.Parse(coordinates.Substring(0,comma-1));
    }
    if (axis == "2")
    {
        result = double.Parse(coordinates.Substring(comma+1,coordinates.Length));
    }

    return result;
}
