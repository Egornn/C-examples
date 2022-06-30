//Задача 2: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int [,] CreateRandomMatrix (int row, int column, int min, int max)
{   
    var rnd=new Random();
    int [,] newMatrix = new int[row,column];
    for (int i=0; i<row; i++)
    {
        for (int j=0; j<column;j++)
        {
            newMatrix[i,j]=rnd.Next(min, max+1);
        }
    }
    return newMatrix;
}


void Transpose (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0);i++)
    {
        for (int j = i+1; j < matrix.GetLength(1);j++)
        {
            var temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}
void PrintArray (int [,] matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1);j++)
        {
            Console.Write($"{matrix[i,j]}"+"\t");
        }
        Console.WriteLine();
    }
}

void TransposeIfPossible(int[,] newMatrix)
{
    if (newMatrix.GetLength(0) == newMatrix.GetLength(1))
    {
        Transpose(newMatrix);
        PrintArray(newMatrix);
    }
    else
    {
        System.Console.WriteLine("Impossible to transpose");
    }
}

void Solve()
{
    int n = 3; 
    int m = 3;
    int min = 2;
    int max = 87;
    int[,] newMatrix = CreateRandomMatrix(n, m, min, max);
    PrintArray(newMatrix);
    System.Console.WriteLine();
    TransposeIfPossible(newMatrix);
}

Solve();

