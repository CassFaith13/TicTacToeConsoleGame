namespace TicTacToeConsoleGame;

public class ProgramUI
{
    static string [] boardArray = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
    static int player = 1;
    static int startPoint; //Where the player wants to place an X or 0
    static int statusCheck = 0; //Checks if player is winning, is tied, or is still playing. 
    public void Run() //string[] args
    {
        StartGame();
    }

    private static void Board()
    {

        // Tic Tac Toe board:
        System.Console.WriteLine("      |       |");
        System.Console.WriteLine("  {0}   |   {1}   |   {2} ", boardArray[0], boardArray[1], boardArray[2]);
        System.Console.WriteLine("      |       |");
        System.Console.WriteLine("______|_______|______");
        System.Console.WriteLine("      |       |");
        System.Console.WriteLine("  {0}   |   {1}   |   {2} ", boardArray[3], boardArray[4], boardArray[5]);
        System.Console.WriteLine("      |       |");
        System.Console.WriteLine("______|_______|______");
        System.Console.WriteLine("      |       |");
        System.Console.WriteLine("  {0}   |   {1}   |   {2} ", boardArray[6], boardArray[7], boardArray[8]);
        System.Console.WriteLine("      |       |");
      
    }
    private static void ClearBoard(){
        for (int i = 0; i < boardArray.Length; i++)
        {
            boardArray[i]=(i+1).ToString();
        }

    }
    private static int CheckWin()
    {
        #region Horizontal Winning Condition
        if (boardArray[0] == boardArray[1] && boardArray[1] == boardArray[2])
        {
            return 1;
        }
        else if (boardArray[3] == boardArray[4] && boardArray[4] == boardArray[5])
        {
            return 1;
        }
        else if (boardArray[5] == boardArray[6] && boardArray[6] == boardArray[7])
        {
            return 1;
        }

        #endregion
        #region Vertical Winning Condition

        else if (boardArray[0] == boardArray[3] && boardArray[3] == boardArray[6])
        {
            return 1;
        }
        else if (boardArray[1] == boardArray[4] && boardArray[4] == boardArray[7])
        {
            return 1;
        }
        else if (boardArray[2] == boardArray[5] && boardArray[5] == boardArray[8])
        {
            return 1;
        }

        #endregion
        #region Diagnoal Winning Condition
        else if (boardArray[0] == boardArray[4] && boardArray[4] == boardArray[8])
        {
            return 1;
        }
        else if (boardArray[2] == boardArray[4] && boardArray[4] == boardArray[6])
        {
            return 1;
        }

        #endregion
        #region Checking For A Draw
        else if (boardArray[0] != "1" && boardArray[1] != "2" && boardArray[2] != "3" && boardArray[3] != "4" && boardArray[4] != "5" && boardArray[5] != "6" && boardArray[6] != "7" && boardArray[7] != "8" && boardArray[8] != "9")
        {
            return -1;
        }

        #endregion
        else
        {
            return 0;

        }
    }
    public void StartGame()
    {
        ClearBoard();
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

            startPoint = int.Parse(Console.ReadLine())-1;

            if (boardArray[startPoint] != "X" && boardArray[startPoint] != "0")
            {
                if (player % 2 == 0)
                {
                    boardArray[startPoint] = "0";
                    player++;
                }
                else
                {
                    boardArray[startPoint] = "X";
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
            if ((player % 2) + 1 == 1)

            {
                Console.WriteLine($"Player {playerOne} has won");
            }
            else
            {
                Console.WriteLine($"Player {playerTwo} has won");
            }

        }
        else
        {
            // ConsoleColor.ForegroundColor = ConsoleColor.DarkYellow;
            System.Console.WriteLine("Neither Player could pull off a win. This game is a Draw!");

        }
        Console.ReadLine();
        Console.WriteLine($"Would you Like to play again? (Y) or (N)");
        var playAgain = Console.ReadLine();
        if (playAgain?.ToLower() == "y")
        {
            StartGame();
        }
    }
}
