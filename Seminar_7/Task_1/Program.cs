// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле:
// Aₘₙ = m+n. Выведите полученный массив на экран

int [,] CreateIndexMatrix (int row, int column)
{
    int [,] newMatrix = new int[row,column];
    for (int i=0; i<row; i++)
    {
        for (int j=0; j<column;j++)
        {
            newMatrix[i,j]=i+j;
        }
    }
    return newMatrix;
}

int Prompt (string message)
{
    Console.WriteLine(message);
    string intString = Console.ReadLine();
    int number = int.Parse (intString);
    return number;
}

void PrintArray (int [,] matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1);j++)
        {
            Console.Write(matrix[i,j]+"\t");
        }
        Console.WriteLine();
    }
}

int n =Prompt ("Input number of rows ");
int m =Prompt ("Input number of columns ");
PrintArray(CreateIndexMatrix(n,m));