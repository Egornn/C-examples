// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


int [,] CreateRandomMatrix (int row, int column, int min, int max) //Usual generator of random matrix
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

void PrintArray (int [,] matrix) // Print array to check the results
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

void MultiplyIfPossible (int [,] matrixA, int [,]matrixB) // Check if #columns in first matrix equals #rows in second one
{
    if (matrixA.GetLength(1)!=matrixB.GetLength(0)) 
    {
        System.Console.WriteLine("It is impossible to muliply");
    }
    else
    {
        int[,] multiplicative = MatrixMultiplication(matrixA, matrixB);
        PrintArray(multiplicative);
    }
}

int [,] MatrixMultiplication(int[,] matrixA, int [,] matrixB)
{
    int[,] multiplicative = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < multiplicative.GetLength(0);i++)
    {
        for (int j = 0; j < multiplicative.GetLength(1); j++)
        {
            for (int k = 0; k < matrixA.GetLength(1);k++)
            {
                multiplicative[i, j] = multiplicative[i, j] + matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return multiplicative;
}

void Solve()
{
    int n = 2; //rows in the first matrix
    int m = 3; //columns in the first matrix
    int o = 3; //rows in the second matrix
    int p = 4; //columns in the second matrix

    int min = 0;
    int max = 10;
    int[,] matrixA = CreateRandomMatrix(n, m, min, max);
    int[,] matrixB = CreateRandomMatrix(o, p, min, max);
    PrintArray(matrixA);
    System.Console.WriteLine();
     PrintArray(matrixB);
    System.Console.WriteLine();
    MultiplyIfPossible(matrixA, matrixB);

}

Solve();
