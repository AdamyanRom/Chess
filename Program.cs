using static System.Console;
using Chess;
OutputEncoding = System.Text.Encoding.UTF8;

string[,] board = new string[8, 8];
MyBoard(board);
PrintMyBoard(board);

Figure Rook = new Figure(" &", "WhiteRook", 1, 1);
UpdateBoard(board, Rook);



static void MyBoard(string[,] board)
{
    
    for (int i = 0; i < 8; i++)
    {
        for (int j = 0; j < 8; j++)
        {
            if ((i + j) % 2 == 0)
            {
                board[i, j] = "██";
            }
            else
            {
                board[i, j] = "  ";
            }
        }
    }
}

static void PrintMyBoard(string[,] board)
{
    Write(" ");
    for (int j = 0; j < 8; j++)
    {
        Write((RowColumns)j + " ");
    }
    WriteLine();
    for (int i = 0; i < 8; i++)
    {
        Write($"{8 - i}");
        for (int j = 0; j < 8; j++)
        {
            Write(board[i, j]);
        }
        WriteLine($"{8 - i}");
    }
    Write(" ");
    for (int j = 0; j < 8; j++)
    {
        Write((RowColumns)j + " ");
    }
    WriteLine();
}


static void UpdateBoard(string[,] board, Figure Rook)
{
    do
    {
        WriteLine("Enter your Figure");
        string figure = ReadLine();
        WriteLine("Enter the row and column where you would like to place a figure.");
        Write("Column (a-h): ");

        string colChar = ReadLine();
        Rook.y = (int)(colChar[0] - 'a');
        Write("\nRow (1-8): ");
        Rook.x = 8 - int.Parse(ReadLine());
        Rook.x = 1;
        Rook.y = 1;
        board[Rook.x, Rook.y] = Rook.Item;
        
        Console.WriteLine($"{Rook.Item}");

        //switch (figure)
        //{
        //    case "Rook":
        //        if (Rook.x == Rook.x && Rook.y <= 8)
        //        {
        //            board[Rook.x, Rook.y] = Rook.Item;
        //        }
        //            break;
        //}
        Clear();
        WriteLine("Updated board:");
        PrintMyBoard(board);
    } while (true);
}
