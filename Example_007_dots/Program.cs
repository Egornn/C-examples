
Console.Clear();

int x0 = 40, y0 = 1,
    x1 = 1, y1 = 30,
    x2 = 80, y2 = 30;  

Console.SetCursorPosition (x0,y0);
Console.WriteLine("+");

Console.SetCursorPosition (x1,y1);
Console.WriteLine("+");

Console.SetCursorPosition (x2,y2);
Console.WriteLine("+");

int x = x0, y = y0;

int count = 0;

while (count<10000)
{
    int what = new Random().Next(0,3);
    if (what == 0)
    {
        x = (x+x0)/2;
        y = (y+y0)/2;

    }
    if (what == 1)
    {
        x = (x+x1)/2;
        y = (y+y1)/2;

    }
    if (what == 2)
    {
        x = (x+x2)/2;
        y = (y+y2)/2;

    }
    Console.SetCursorPosition(x,y);
    Console.WriteLine(".");
    count+=1;
}
Console.SetCursorPosition(1,31);