// Задача 3: Задайте двумерный массив. Найдите сумму элементов главной диагонали.


int Prompt (string message)
{
    Console.WriteLine(message);
    string intString = Console.ReadLine();
    return int.Parse (intString);
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

int SumOfMainDiagonal (int [,] matrix)
{
    int sum = 0;
    int i = 0;
    while (i<matrix.GetLength(0) && i<matrix.GetLength(1))
    {
        sum=sum+matrix[i,i];
        i++;
    }
    return sum;
}

int n =Prompt ("Input number of rows ");
int m =Prompt ("Input number of columns ");
int min =Prompt ("Input minum ");
int max =Prompt ("Input maximum ");

int [,] myArray = CreateRandomMatrix(n,m,min,max);

PrintArray(myArray);

Console.WriteLine();

Console.WriteLine($"Sum on main diaonal is {SumOfMainDiagonal(myArray)}");

