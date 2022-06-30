//Задача 1: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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
void SwapTopAndBottomRows (int [,] matrix)
{
        //1 2 3 
    for (int i = 0; i < matrix.GetLength(1);i++)   // 4 5 6 
    {
        var temp = matrix[matrix.GetLength(0)-1,i]; // [4,0,0]
        matrix[matrix.GetLength(0)-1, i] = matrix[0, i]; // 1,5,6
        matrix[0, i]=temp; // 4,2,3
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
int n = 3; //Prompt ("Input number of rows ");
int m = 5;//Prompt ("Input number of columns ");
int min = 2;//Prompt ("Input minum ");
int max = 87;//Prompt ("Input maximum ");

int[,] forTransformation = CreateRandomMatrix(n, m, min, max);
PrintArray(forTransformation);
SwapTopAndBottomRows(forTransformation);
System.Console.WriteLine();
PrintArray(forTransformation);

