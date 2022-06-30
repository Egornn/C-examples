// Задача 3: Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных. Значения элементов массива 0..9


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

int [] CountNumbers (int [,] matrix)
{
    int [] dictionary = new int[10];
    for (int i = 0; i < matrix.GetLength(0);i++)
    {
        for (int j = 0; j < matrix.GetLength(1);j++)
        {
            if (matrix[i,j]>=0 && matrix[i,j]<10)
            {
                dictionary[matrix[i, j]]++;
            }
        }
    }
        return dictionary;
}
void PrintDictionary (int [] dict)
{
    for (int i = 0; i < dict.Length;i++)
    {
        System.Console.WriteLine($"Число {i} в массиве встречается {dict[i]} раз");
    }
}

void Solve()
{
    int n = 3; 
    int m = 3;
    int min = 0;
    int max = 10;
    int[,] newMatrix = CreateRandomMatrix(n, m, min, max);
    PrintArray(newMatrix);
    System.Console.WriteLine();
    PrintDictionary(CountNumbers(newMatrix));
}

Solve();
