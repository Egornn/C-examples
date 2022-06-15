//Задача 2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// Get two dots in space return the distance
string prompt(string msg)
{
    System.Console.WriteLine(msg);
    string coordinates = System.Console.ReadLine(); 
    return coordinates;
}

double Coordinate(string coordinates,string axis)
{
    int comma1 = 0;
    int comma2=0;
    double result = 0;
    int length = coordinates.Length;
    for (int counter = 0; counter <  length; counter++ )
    {
        if (coordinates[counter] == '.') 
        {
            if (comma1==0)
            {
                comma1=counter;
            }
            else
            {
                comma2=counter;
            }
        }
    }
    string numberstr= String.Empty;
    if (axis == "x") 
    {
        numberstr = coordinates.Substring(0,comma1);
        result = double.Parse(numberstr);
    }
    if (axis == "y")
    {
        numberstr = coordinates.Substring(comma1+1,comma2-comma1-1);
        result = double.Parse(numberstr);
    }
    if (axis == "z")
    {
        numberstr = coordinates.Substring(comma2+1);
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


string coordinates1 = prompt ("Input coorinates in the form x1.y1.z1");
string coordinates2 = prompt ("Input coorinates in the form x2.y2.z2");
// string coordinates1= "111,222";
// double x1=Coordinate(coordinates1,"x");
// double y1=Coordinate(coordinates1,"y");
double x1 = Coordinate (coordinates1,"x");
double y1 = Coordinate (coordinates1,"y");
double z1 = Coordinate (coordinates1,"z");

double x2 = Coordinate (coordinates2,"x");
double y2 = Coordinate (coordinates2,"y");
double z2 = Coordinate (coordinates2,"z");

 Console.WriteLine(x1);
 Console.WriteLine(y1);
 Console.WriteLine(z1);
 Console.WriteLine(x2);
 Console.WriteLine(y2);
 Console.WriteLine(z2);


double distance= Math.Sqrt (powerx(x1-x2,2)+powerx(y1-y2,2)+powerx(z1-z2,2));
Console.WriteLine($"The distance between {coordinates1} and {coordinates2} is {distance}");
