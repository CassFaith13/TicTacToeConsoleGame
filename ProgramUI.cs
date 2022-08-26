public class ProgramUI
{
        static char[] boardArray = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1; 
        static int startPoint; //Where the player wants to start the game
        static int statusCheck = 0; //Checks if player is winning, is tied, or is still playing. 
    public void Run(string[] args)
    {
        // do {
                // Choosing player turn
                // Where to place and if place is already full, reloading board so player can choose again.
        // }
        // while {
                // Call WinStatus to constantly check if a player has won or drawn.
        // }
    }


    private static void Board()
        {
            // Tic Tac Toe board:
            System.Console.WriteLine("     |         |");
            System.Console.WriteLine("     |         |");
            System.Console.WriteLine("_____|_________|_____");
            System.Console.WriteLine("     |         |");
            System.Console.WriteLine("     |         |");
            System.Console.WriteLine("_____|_________|_____");
            System.Console.WriteLine("     |         |");
            System.Console.WriteLine("     |         |");
        }

    private static int WinStatus()
    {
        // Check for a win in each column and row
        // Check for a draw

    }

    }
