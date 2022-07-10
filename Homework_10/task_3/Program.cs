// Задача 3*: Задача 1: Заполните спирально квадратный массив по возрастанию, с заданным размером:

int Prompt (string console)
{
    System.Console.WriteLine(console);
    string numberStr = Console.ReadLine();
    return int.Parse(numberStr);
}
void PrintMatrix (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

void Spiralinside (int [,] matrix, int startingValue , int coordinateX=0, int coordinateY=0, int incrimentX=0, int incrimentY=1)
{
    {
        matrix[coordinateX, coordinateY] = startingValue--;
        if (startingValue == 0) { return; }
        if (incrimentY==1)
        {
            if (coordinateY==matrix.GetLength(1)-1||matrix[coordinateX,coordinateY+incrimentY]>0)
            {
                incrimentX = 1;
                incrimentY = 0;
            }
        }
        else
        {
            if (incrimentY==-1)
            {
                if (coordinateY==0||matrix[coordinateX,coordinateY+incrimentY]>0)
                {   
                    incrimentX = -1;
                    incrimentY = 0;
                }
            }
            else
            {
                if (incrimentX==1)
                {
                if (coordinateX==matrix.GetLength(0)-1||matrix[coordinateX+incrimentX,coordinateY]>0)
                {
                    incrimentX = 0;
                    incrimentY = -1;
                }
                }
                else
                {
                    if (incrimentX==-1)
                    {
                        if (coordinateX==0||matrix[coordinateX+incrimentX,coordinateY]>0)
                        {
                            incrimentX = 0;
                            incrimentY = 1;
                        }
                    }
                }
            }
        }
    }
    Spiralinside(matrix, startingValue, coordinateX + incrimentX, coordinateY + incrimentY, incrimentX, incrimentY);
}

void Solve()
{
    int N = Prompt("How big is a matrix?");
    int[,] squareMatrix = new int[N, N];
    Spiralinside(squareMatrix, squareMatrix.GetLength(0)*squareMatrix.GetLength(1));
    PrintMatrix(squareMatrix);
}

Solve();

