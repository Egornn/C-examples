// Get two dots in space return the distance
string prompt(string msg)
{
    System.Console.WriteLine(msg);
    string coordinates = System.Console.ReadLine(); 
    return coordinates;
}

double Coordinate(string coordinates,string axis)
{
    int comma = 0;
    double result = 0;
    int length = coordinates.Length;
    for (int counter = 0; counter <  length; counter++ )
    {
        if (coordinates[counter] == ',') 
        {
            comma=counter;
        }
    }
    string numberstr= String.Empty;
    if (axis == "x") 
    {
        numberstr = coordinates.Substring(0,comma);
        result = double.Parse(numberstr);
    }
    if (axis == "y")
    {
        numberstr = coordinates.Substring(comma+1);
        result = double.Parse(numberstr);
    }

    return result;
}

double powerx(double based, int power)
{
    double result = 1;
    for (int i = 0; i<power;i++)
    {
        result=result*based;
    }
    return result;
}


string coordinates1 = prompt ("Input coorinates in the form x1,y1");
string coordinates2 = prompt ("Input coorinates in the form x2,y2");
// string coordinates1= "111,222";
// double x1=Coordinate(coordinates1,"x");
// double y1=Coordinate(coordinates1,"y");
// Console.WriteLine(x1);
// Console.WriteLine(y1);
double x1 = Coordinate (coordinates1,"x");
double y1 = Coordinate (coordinates1,"y");
double x2 = Coordinate (coordinates2,"x");
double y2 = Coordinate (coordinates2,"y");

Console.WriteLine(x1+" "+y1+", "+x2+" "+y2);
double distance= Math.Sqrt (powerx(x1-x2,2)+powerx(y1-y2,2));
Console.WriteLine($"The distance between {coordinates1} and {coordinates2} is {distance}");
