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
        {".","/",".","."},
        {".","/",".","."},
        {".","/",".","."},
        {".","/",".","."},
        };   
    string [,] T = new string [,]
        {
        {".",".",".","."},
        {".",".",".","."},
        {".","/",".","."},
        {"/","/","/","."},
        };
    string [,] ZL = new string [,]
        {
        {".",".",".","."},
        {".",".",".","."},
        {".","/","/","."},
        {"/","/",".","."},
        };
    string [,] ZR = new string [,]
        {
        {".",".",".","."},
        {".",".",".","."},
        {"/","/",".","."},
        {".","/","/","."},
        };  
    string [,] Square = new string [,]
        {
        {".",".",".","."},
        {".",".",".","."},
        {".","/","/","."},
        {".","/","/","."},
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
string [,] AddNewPieceOnTop (string [,] board, string [,] piece)
{
    for (int i=0; i<piece.GetLength(0);i++)
    {
        for (int j=3; j<piece.GetLength(1);j++)
        {
            board[i,j]=piece[i,j];
        }
    }
    return board;
}
string [,] DownOne (string [,] board)
{
    return board;  
}
int [] CoordinatesOfNewPiece (string [,] piece)
{
    int [] coordinates4 = new int [8];
    int xy =0;
    for (int i=0; i<piece.GetLength(0);i++)
    {
        for (int j=0; j<piece.GetLength(1);j++)
        {
            if (piece[i,j]=="/") 
            {
                coordinates4[xy]=i;
                coordinates4[xy+1]=j;
                xy=xy+2;
            }
        }
    }
    return coordinates4;
}


string [,] CurrentBoard = EmptyBoard();
string [,] CurrentPiece=NewPiece();
// Console.WriteLine(CurrentBoard.GetLength(0));
// Console.WriteLine(CurrentBoard.GetLength(1));
// PrintBoard(CurrentBoard,1);
int [] coordinates = CoordinatesOfNewPiece(CurrentPiece);
PrintBoard(CurrentPiece, 1);
// for (int i=0; i<coordinates.Length;i++)
// {
//     Console.Write(coordinates[i]);
// }
// Console.WriteLine();
// string [,] Empty = new string [,]
//         {
//         {".",".",".","."},
//         {".",".",".","."},
//         {".",".",".","."},
//         {".",".",".","."},
//         };   
// for (int i=0; i<coordinates.Length;i=i+2)
// {
//     Empty[coordinates[i],coordinates[i+1]]="?";
//     PrintBoard(Empty,1);
//     Console.WriteLine();
// }
