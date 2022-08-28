namespace TicTacToeConsoleGame;

public class ProgramUI
{
        static char[] boardArray = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1; 
        static int startPoint; //Where the player wants to place an X or 0
        static int statusCheck = 0; //Checks if player is winning, is tied, or is still playing. 

    public void Run() //string[] args
    {
        // ConsoleColor.ForegroundColor = ConsoleColor.Red;
        Console.Clear();
        System.Console.WriteLine("Welcome to our Tic Tac Toe game. The board is numbered 1 - 9 and the spaces are considered 'empty' if there is a number in it. In order to play, each player will choose to place their X or O to a numbered space on the board. The first player to get three in a row wins. Press any key to begin the game!");
        Console.ReadKey();

        // ConsoleColor.ForegroundColor = ConsoleColor.DarkBlue;
        System.Console.WriteLine("What is your name Player 1?");
        string? playerOne = Console.ReadLine();

        // ConsoleColor.ForegroundColor = ConsoleColor.DarkBlue;
        System.Console.WriteLine("What is your name Player 2?");
        string? playerTwo = Console.ReadLine();
        
         do
        {
            Console.Clear();
            // ConsoleColor.ForegroundColor = ConsoleColor.Cyan;
            System.Console.WriteLine($"{playerOne}: X and {playerTwo}: O");
            System.Console.WriteLine("\n");

            Board();
            if (player % 2 == 0)
            {   
                // ConsoleColor.ForegroundColor = ConsoleColor.DarkGreen;
                System.Console.WriteLine($"{playerTwo}'s Turn. Choose a numbered space.");
            }
            else
            {
                // ConsoleColor.ForegroundColor = ConsoleColor.DarkGreen;
                System.Console.WriteLine($"{playerOne}'s Turn. Choose a numbered space.");
            }
            System.Console.WriteLine("\n");

            startPoint = int.Parse(Console.ReadLine());

            if (boardArray[startPoint] != 'X' && boardArray[startPoint] != '0')
            {
                if (player % 2 == 0)
                {
                boardArray[startPoint] = '0';
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
                // ConsoleColor.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("That space has already been claimed. Try another space.");
                System.Console.WriteLine("\n");
                System.Console.WriteLine("Please wait for a new board to load......");
                Thread.Sleep(2000);
            }

        statusCheck = CheckWin();
        }    
            while (statusCheck != 1 && statusCheck != -1);

            Console.Clear();
            Board();

            if (statusCheck == 1)
            {
                // if ((player % 2) + 1 == playerTwo) //I want to make it say the Player's name but could not make int = bool. 
                // {
                //     System.Console.WriteLine($"Congratulations! {playerTwo} has won the game!");
                // }
                // else
                // { 
                // // ConsoleColor.ForegroundColor = ConsoleColor.DarkYellow;
                // System.Console.WriteLine($"Congratulations! {playerOne} has won");
                // }
                Console.WriteLine("Player {0} has won", (player % 2) + 1);
            }
            else
            {
                // ConsoleColor.ForegroundColor = ConsoleColor.DarkYellow;
                System.Console.WriteLine("Neither Player could pull off a win. This game is a Draw!");
            }

            Console.ReadLine();
        }

    private static void Board()
{
    // Tic Tac Toe board:
    System.Console.WriteLine("      |       |");
    System.Console.WriteLine("  {0}   |   {1}   |   {2} ", boardArray[1], boardArray[2], boardArray[3]);
    System.Console.WriteLine("      |       |");
    System.Console.WriteLine("______|_______|______");
    System.Console.WriteLine("      |       |");
    System.Console.WriteLine("  {0}   |   {1}   |   {2} ", boardArray[4], boardArray[5], boardArray[6]);
    System.Console.WriteLine("      |       |");
    System.Console.WriteLine("______|_______|______");
    System.Console.WriteLine("      |       |");
    System.Console.WriteLine("  {0}   |   {1}   |   {2} ", boardArray[7], boardArray[8], boardArray[9]);
    System.Console.WriteLine("      |       |");

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
}