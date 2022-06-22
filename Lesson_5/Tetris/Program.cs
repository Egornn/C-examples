// Tetris
string [,] EmptyBoard()
{
    string [,] Board = new string [,]{
        {".",".",".",".",".",".",".",".",".","."},
        {".",".",".",".",".",".",".",".",".","."},
        {".",".",".",".",".",".",".",".",".","."},
        {".",".",".",".",".",".",".",".",".","."},        
        {".",".",".",".",".",".",".",".",".","."},
        {".",".",".",".",".",".",".",".",".","."},
        {".",".",".",".",".",".",".",".",".","."},
        {".",".",".",".",".",".",".",".",".","."},
        {".",".",".",".",".",".",".",".",".","."},
        {".",".",".",".",".",".",".",".",".","."},
        {".",".",".",".",".",".",".",".",".","."},
        {".",".",".",".",".",".",".",".",".","."},
        {".",".",".",".",".",".",".",".",".","."},
        {".",".",".",".",".",".",".",".",".","."},

    };
    return Board;
}
void PrintBoard(string [,] CurrentBoard,int FirstLine)
{
    for (int i=FirstLine-1; i< CurrentBoard.GetLength(0);i++)
    {
        for (int j=0; j<CurrentBoard.GetLength(1);j++)
        {
            Console.Write(CurrentBoard[i,j]);
        }
        Console.WriteLine();
    }
}
string [,] NewPiece()
{
    string [,] Empty = new string [,]
        {
        {".",".",".","."},
        {".",".",".","."},
        {".",".",".","."},
        {".",".",".","."},
        };   
    string [,] Long = new string [,]
        {
        {".","+",".","."},
        {".","+",".","."},
        {".","+",".","."},
        {".","+",".","."},
        };   
    string [,] T = new string [,]
        {
        {".",".",".","."},
        {".",".",".","."},
        {".","+",".","."},
        {"+","+","+","."},
        };
    string [,] ZL = new string [,]
        {
        {".",".",".","."},
        {".",".",".","."},
        {".","+","+","."},
        {"+","+",".","."},
        };
    string [,] ZR = new string [,]
        {
        {".",".",".","."},
        {".",".",".","."},
        {"+","+",".","."},
        {".","+","+","."},
        };  
    string [,] Square = new string [,]
        {
        {".",".",".","."},
        {".",".",".","."},
        {".","+","+","."},
        {".","+","+","."},
        }; 
    int RandomPick = new Random().Next(0,4);
    if (RandomPick==0) {return Long;}
    if (RandomPick==1) {return T;}
    if (RandomPick==2) {return Square;}
    if (RandomPick==3) 
    {
        int LorR = new Random().Next(0,2);
        if (LorR==0){return ZR;}
        else {return ZL;}
    }
    return Empty;
    
    
} 


// string [,] CurrentBoard = EmptyBoard();
string [,] CurrentBoard=NewPiece();
Console.WriteLine(CurrentBoard.GetLength(0));
Console.WriteLine(CurrentBoard.GetLength(1));
PrintBoard(CurrentBoard,1);
