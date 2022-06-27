// Задайте двумерный массив. Введите элемент, и найдите первое его вхождение, 
//выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.

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

string FindNumber (int [,] matrix, int number)
{
   string result = "There is no such number in the matrix";
   for (int i =0; i<matrix.GetLength(0);i++)
   {
        for (int j=0; j<matrix.GetLength(1);j++)
        {
            if (matrix[i,j]==number)
            {
                result = $"The first position of {number} is [{i+1}, {j+1}]";
                return result;
            }
        }
   }
    return result;
}

int n =Prompt ("Input number of rows ");
int m =Prompt ("Input number of columns ");
int min =Prompt ("Input minum ");
int max =Prompt ("Input maximum ");
int number =Prompt ("Input number to look ");


int [,] myArray = CreateRandomMatrix(n,m,min,max);

PrintArray(myArray);

Console.WriteLine();

Console.WriteLine($"The result of a find in the generated array {FindNumber(myArray, number)}");
