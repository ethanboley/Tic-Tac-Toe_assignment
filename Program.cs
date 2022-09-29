class TicTacToe
{
    static void Main(string[] args)
    {

        List<string> gameboard = GetNewBoard();
        string currentPlayer = "x";

        while (!IsGameOver(gameboard))
        {
            DisplayBoard(gameboard);

            int choice = GetMoveChoice(currentPlayer);
            MakeMove(gameboard, choice, currentPlayer);

            currentPlayer = GetNextPlayer(currentPlayer);
        }

        DisplayBoard(gameboard);
        Console.WriteLine("Good game. Thanks for playing!");
    }

    /// <summary>Gets a new instance of the board with the numbers 1-9 in place. </summary>
    /// <returns>A list of 9 strings representing each square.</returns>
    static List<string> GetNewBoard()
    {
        // return new List<string> x =('1', '2', '3', '4', '5', '6', '7', '8', '9');
        List<string> gameboard = new List<string>();

        for (int i = 1; i <=9; i++)
        {
            gameboard.Add(i.ToString());
        }
        return gameboard;


    }

    // <summary>Displays the gameboard in a 3x3 grid.</summary>
    // <param name="gameboard">The gameboard</param>
    static void DisplayBoard(List<string> gameboard)
    {
        Console.WriteLine($"{gameboard[0]}|{gameboard[1]}|{gameboard[2]}");
        Console.WriteLine("--+--+--");
        Console.WriteLine($"{gameboard[3]}|{gameboard[4]}|{gameboard[5]}");
        Console.WriteLine("--+--+--");
        Console.WriteLine($"{gameboard[6]}|{gameboard[7]}|{gameboard[8]}");
    }

    // <summary>
    // Determines if the game is over because of a win or a tie.
    // </summary>
    // <param name="board">The current board.</param>
    // <returns>True if the game is over</returns>
    static bool IsGameOver(List<string> gameboard)
    {        
        return IsWinner(gameboard, "x") || IsWinner(gameboard, "o") || IsTie(gameboard);
    }

    // <summary>Determines if the provided player has a tic tac toe.</summary>
    // <param name="board">The current board</param>
    // <param name="player">The player to check for a win</param>
    // <returns></returns>
    static bool IsWinner(List<string> gameboard, string player)
    {
        if (gameboard[0] == player && gameboard[1] == player && gameboard[2] == player
         || gameboard[3] == player && gameboard[4] == player && gameboard[5] == player
         || gameboard[6] == player && gameboard[7] == player && gameboard[8] == player
         || gameboard[0] == player && gameboard[4] == player && gameboard[8] == player
         || gameboard[2] == player && gameboard[4] == player && gameboard[6] == player
         || gameboard[0] == player && gameboard[3] == player && gameboard[6] == player
         || gameboard[1] == player && gameboard[4] == player && gameboard[7] == player
         || gameboard[2] == player && gameboard[5] == player && gameboard[8] == player)
        {
            return true;
        }

        return false;
    }

    // <summary>Determines if the board is full with no more moves possible.</summary>
    // <param name="board">The current board.</param>
    // <returns>True if the board is full.</returns>
    static bool IsTie(List<string> gameboard)
    {
        foreach (string value in gameboard)
        {
            if (char.IsDigit(value[0]))
            {
                return true;
            }   
        }
        return false;
    }

    // <summary>Cycles through the players (from x to o and o to x)</summary>
    // <param name="currentPlayer">The current players sign (x or o)</param>
    // <returns>The next players sign (x or o)</returns>
    static string GetNextPlayer(string currentPlayer)
    {
        return "x";
    }

    /// <summary>Gets the 1-based spot number associated with the user's choice.</summary>
    /// <param name="currentPlayer">The sign (x or o) of the current player.</param>
    /// <returns>A 1-based spot number (not a 0-based index)</returns>
    static int GetMoveChoice(string currentPlayer)
    {
        return 1;
    }

    /// <summary>
    /// Places the current players mark on the board at the desired spot.
    /// This method does NOT check to ensure the spot is available.
    /// </summary>
    /// <param name="board">The current board</param>
    /// <param name="choice">The 1-based spot number (not a 0-based index).</param>
    /// <param name="currentPlayer">The current player's sign (x or o)</param>
    static void MakeMove(List<string> board, int choice, string currentPlayer)
    {

    }
}
