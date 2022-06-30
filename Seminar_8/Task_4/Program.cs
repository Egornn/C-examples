// Задача 4: Задайте двумерный массив из целых чисел. 
//Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.



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

int [] MinimumPosition (int [,] matrix)
{
    int [] coordinates = new int[2];
    for (int i = 0; i < matrix.GetLength(0);i++)
    {
        for (int j = 0; j < matrix.GetLength(1);j++)
        {
            if (matrix[i,j]<matrix[coordinates[0],coordinates[1]])
            {
                coordinates[0] = i;
                coordinates[1] = j;
            }
        }
    }

    return coordinates;
} 
int [,] RemoveRow(int [,] matrix, int minRow)
{
    int[,] shortM = new int[matrix.GetLength(0) - 1, matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i < minRow) {shortM[i, j] = matrix[i, j];}
            if (i > minRow) {shortM[i-1, j] = matrix[i, j];}
        }
    }
    return shortM;
}
int [,] RemoveColumn(int [,] matrix, int minColumn)
{
    int[,] shortM = new int[matrix.GetLength(0) , matrix.GetLength(1)-1];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < minColumn) {shortM[i, j] = matrix[i, j];}
            if (j > minColumn) {shortM[i, j-1] = matrix[i, j];}
        }
    }
    return shortM;
}

// int [,] RemoveColumnAndRow(int [,] matrix, int minRow, int minColumn)
// {
//     int[,] shortM = new int[matrix.GetLength(0)-1 , matrix.GetLength(1)-1];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
        
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i < minRow&&j<minColumn) {shortM[i, j] = matrix[i, j];}
//             if (i > minRow&&j<minColumn) {shortM[i-1, j] = matrix[i, j];}
//             if (j > minColumn && i< minRow) {shortM[i, j-1] = matrix[i, j];}
//             if (j > minColumn && i> minRow) {shortM[i-1, j-1] = matrix[i, j];}
//             System.Console.WriteLine(i+" "+j);
//         }
//     }
//     return shortM;
// }


void Solve()
{
    int n = 3;
    int m = 5;
    int min = 0;
    int max = 10;
    int[,] newMatrix = CreateRandomMatrix(n, m, min, max);
    PrintArray(newMatrix);
    System.Console.WriteLine();

    int[,] shortR = RemoveRow(newMatrix, MinimumPosition(newMatrix)[0]);
    PrintArray(shortR);
    System.Console.WriteLine();
    int[,] shortFinal = RemoveColumn(shortR, MinimumPosition(newMatrix)[1]);
    PrintArray(shortFinal);

    //System.Console.WriteLine();
    //shortFinal = RemoveColumnAndRow(shortR, MinimumPosition(newMatrix)[0], MinimumPosition(newMatrix)[1]);
    //PrintArray(shortFinal);


}

Solve();
