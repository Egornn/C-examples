// Задача 2: Задайте двумерный массив. Найдите элементы, у 
//которых обе позиции чётные, и замените эти элементы на их квадраты.

// int [,] CreateRandomMatrix (int row, int column, int min, int max)
// {   
//     var rnd=new Random();
//     int [,] newMatrix = new int[row,column];
//     for (int i=0; i<row; i++)
//     {
//         for (int j=0; j<column;j++)
//         {
//             newMatrix[i,j]=rnd.Next(min, max+1);
//         }
//     }
//     return newMatrix;
// }

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

void SquareEvenPosition (int [,] matrix)
{
    for (int i=0; i<matrix.GetLength(0);i++)
    {
        for (int j=0;j<matrix.GetLength(1);j++)
        {
            if ((i+1) % 2 == 0 && (j+1) % 2 == 0)
            {
                matrix[i,j]= matrix[i,j]*matrix[i,j];
            }
        }
    }
}



int n =Prompt ("Input number of rows ");
int m =Prompt ("Input number of columns ");
int min =Prompt ("Input minum ");
int max =Prompt ("Input maximum ");

int [,] myArray = CreateRandomMatrix(n,m,min,max);

PrintArray(myArray);
SquareEvenPosition(myArray);
Console.WriteLine();
PrintArray(myArray);
