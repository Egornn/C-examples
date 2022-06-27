//Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.

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
            Console.Write($"{matrix[i,j]}"+"\t");
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
int [] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition)
{   
    int [] number={0,-1};
    if ((rowPosition-1)<=matrix.GetLength(0) && (columnPosition-1)<=matrix.GetLength(1) )
    {
        number[1]=0;
        number[0]=matrix[rowPosition-1,columnPosition-1];
        return number;
    }
    return number;
}
void PrintCheckIfError (int[] results, int X, int Y)
{
    if (results[1]==-1){Console.WriteLine("There is no such index");}
    else {Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
    }
}


int n =Prompt ("Input number of rows ");
int m =Prompt ("Input number of columns ");
int min =Prompt ("Input minum ");
int max =Prompt ("Input maximum ");
int i =Prompt ("Input row position ");
int j =Prompt ("Input column position ");



int [,] myArray = CreateRandomMatrix(n,m,min,max);

PrintArray(myArray);

PrintCheckIfError(FindNumberByPosition(myArray, i, j),i,j);
