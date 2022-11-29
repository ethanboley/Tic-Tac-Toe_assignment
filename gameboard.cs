class GameBoard {

    List<string> spaces = new List<string>();

    public GameBoard() {

        for (int i = 1; i <=9; i++) {
            spaces.Add(i.ToString());
        }
    }

    // public void print() {
    //     Console.WriteLine($"{spaces[0]}|{spaces[1]}|{spaces[2]}");
    //     Console.WriteLine("--+--+--");
    //     Console.WriteLine($"{spaces[3]}|{spaces[4]}|{spaces[5]}");
    //     Console.WriteLine("--+--+--");
    //     Console.WriteLine($"{spaces[6]}|{spaces[7]}|{spaces[8]}");
    // }

    public List<string> make_gameboard_list() 
    {
        List<string> gameboard = new List<string>();
        // 1st line
        gameboard.Add($"{spaces[0]}");
        gameboard.Add($"{spaces[1]}");
        gameboard.Add($"{spaces[2]}");
        // 2nd line
        gameboard.Add($"{spaces[3]}");
        gameboard.Add($"{spaces[4]}");
        gameboard.Add($"{spaces[5]}");
        // 3rd line
        gameboard.Add($"{spaces[6]}");
        gameboard.Add($"{spaces[7]}");
        gameboard.Add($"{spaces[8]}");

        return gameboard;
    }
    
}
