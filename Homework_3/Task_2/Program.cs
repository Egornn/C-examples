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
string coordinates3 = prompt ("Input coorinates in the form x3.y3.z3");
// string coordinates1= "111,222";
// double x1=Coordinate(coordinates1,"x");
// double y1=Coordinate(coordinates1,"y");
double x1 = Coordinate (coordinates1,"x");
double y1 = Coordinate (coordinates1,"y");
double z1 = Coordinate (coordinates1,"z");

double x2 = Coordinate (coordinates2,"x");
double y2 = Coordinate (coordinates2,"y");
double z2 = Coordinate (coordinates2,"z");

double x3 = Coordinate (coordinates3,"x");
double y3 = Coordinate (coordinates3,"y");
double z3 = Coordinate (coordinates3,"z");
 Console.WriteLine(x1);
 Console.WriteLine(y1);
 Console.WriteLine(z1);
 Console.WriteLine(x2);
 Console.WriteLine(y2);
 Console.WriteLine(z2);
 Console.WriteLine(x3);
 Console.WriteLine(y3);
 Console.WriteLine(z3);


double distance12= Math.Sqrt (powerx(x1-x2,2)+powerx(y1-y2,2)+powerx(z1-z2,2));
double distance13= Math.Sqrt (powerx(x1-x3,2)+powerx(y1-y3,2)+powerx(z1-z3,2));
double distance23= Math.Sqrt (powerx(x3-x2,2)+powerx(y3-y2,2)+powerx(z3-z2,2));
Console.WriteLine($"The distance between {coordinates1} and {coordinates2} is {distance12}");
Console.WriteLine($"The distance between {coordinates1} and {coordinates3} is {distance13}");
Console.WriteLine($"The distance between {coordinates2} and {coordinates3} is {distance23}");
