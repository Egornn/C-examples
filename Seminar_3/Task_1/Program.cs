// By given quadrants return possible x,y range
string prompt (string msg)
{
    Console.WriteLine (msg);  
    return Console.ReadLine();  
} 

int quadrants = int.Parse(prompt("Enter the quadrants of interest"));
string x=">", y=">";
if (quadrants<1 || quadrants>4){Console.WriteLine ("There are only 4 quadrants");}
else{
if (quadrants==2 || quadrants == 3)
{
    x="<";
} 
if (quadrants==3 || quadrants == 4)
{
    y="<";
} 

Console.WriteLine($"for the quadrants {quadrants} x{x}0 and y{y}0");
}