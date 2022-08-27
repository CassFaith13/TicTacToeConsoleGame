
public class ProgramUI
{

    static char[] boardArray = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static int player = 1;
    static int startPoint; //Where the player wants to start the game
    static int statusCheck = 0; //Checks if player is winning, is tied, or is still playing. 
    public void Run(string[] args)
    {
        do
        {
            Console.Clear();
            System.Console.WriteLine("Player 1:X and Player 2:O");
            System.Console.WriteLine("\n");
            if (player % 2 == 0)
            {
                System.Console.WriteLine("Player 2 Chance");
            }
            else
            {
                System.Console.WriteLine("Player 1 Chance");
            }
            System.Console.WriteLine("\n");
            Board();
            startPoint = int.Parse(Console.Readline());
            if (boardArray[startPoint] != 'X' && boardArray[startPoint] != '0')
            {
                boardArray[startPoint] = 'O';
                player++;
            }
            else
            {
                boardArray[startPoint] = 'X';
                player++;
            }
        }
         else
        {
            System.Console.WriteLine("That row already {0} already contains a {1}", startPoint, boardArray[startPoint]);
            System.Console.WriteLine("\n");
            System.Console.WriteLine("You must wait 2 seconds for the board to load again......");
            Thread.Sleep(2000);
        }
        statusCheck = CheckWin();
    }    
            while (statusCheck != 1 && statusCheck != -1);
            Console.Clear();
            Board();
            if (statusCheck == 1)
            {
                System.Console.WriteLine("Player {0} has won", (player % 2) + 1);
            }
            else
            {
                System.Console.WriteLine("Draw");
            }
            Console.Readline();
        }

    private static void Board()
{
    // Tic Tac Toe board:
    System.Console.WriteLine("     |         |");
    System.Console.WriteLine("    {0}    |  {1}   |    {2} ", boardArray[1], boardArray[2], boardArray[3]);
    System.Console.WriteLine("     |         |");
    System.Console.WriteLine("_____|_________|_____");
    System.Console.WriteLine("     |         |");
    System.Console.WriteLine("   {0}    |   {1}   |    {2} ", boardArray[4], boardArray[5], boardArray[6]);
    System.Console.WriteLine("     |         |");
    System.Console.WriteLine("_____|_________|_____");
    System.Console.WriteLine("     |         |");
    System.Console.WriteLine("    {0}    |    {1}   |    {2} ", boardArray[7], boardArray[8], boardArray[9]);
    System.Console.WriteLine("     |         |");

}
private static int CheckWin()
{
    #region Horizontal Winning Condition
    if (boardArray[1] == boardArray[2] && boardArray[2] == boardArray[3])
    {
        return 1;
    }
    else if (boardArray[4] == boardArray[5] && boardArray[5] == boardArray[6])
    {
        return 1;
    }
    else if (boardArray[6] == boardArray[7] && boardArray[7] == boardArray[8])
    {
        return 1;
    }
    #endregion
    #region Vertical Winning Condition

    else if (boardArray[1] == boardArray[4] && boardArray[4] == boardArray[7])
    {
        return 1;
    }
    else if (boardArray[2] == boardArray[5] && boardArray[5] == boardArray[8])
    {
        return 1;
    }
    else if (boardArray[3] == boardArray[6] && boardArray[6] == boardArray[9])
    {
        return 1;
    }
    #endregion
    #region Diagnoal Winning Condition
    else if (boardArray[1] == boardArray[5] && boardArray[5] == boardArray[9])
    {
        return 1;
    }
    else if (boardArray[3] == boardArray[5] && boardArray[5] == boardArray[7])
    {
        return 1;
    }
    #endregion
    #region Checking For A Draw
    else if (boardArray[1] != '1' && boardArray[2] != '2' && boardArray[3] != '3' && boardArray[4] != '4' && boardArray[5] != '5' && boardArray[6] != '6' && boardArray[7] != '7' && boardArray[8] != '8' && boardArray[9] != '9')
    {
        return -1;
    }
    #endregion
    else
    {
        return 0;
    }
}



         
                // Choosing player turn
                // Where to place and if place is already full, reloading board so player can choose again.
        // }
        // while {
                // Call WinStatus to constantly check if a player has won or drawn.
        // }
        
    /*private static int WinStatus()
    {
        // Check for a win in each column and row
        // Check for a draw

    }*/