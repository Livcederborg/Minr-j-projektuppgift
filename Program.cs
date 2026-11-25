


char[,] board =
{
    {'B', 'B', '1', '1', '1', '1', 'S', 'S', 'S'},
    {'2', '3', '2', '2', 'B', '1', 'S', 'S', 'S'},
    {'B', '2', 'B', '2', '1', '1', 'S', '1', '1'},
    {'1', '2', '1', '1', 'S', 'S', 'S', '1', 'B'},
    {'S', 'S', 'S', 'S', 'S', 'S', 'S', '2', '2'},
    {'S', 'S', '1', '1', '1', '1', '1', '2', 'B'},
    {'S', 'S', '1', 'B', '1', '1', 'B', '3', '2'},
    {'S', 'S', '1', '1', '2', '2', '2', '2', 'B'},
    {'S', 'S', 'S', 'S', '1', 'B', '1', '1', 'S'},
};

Position position = new Position (5, 0, board.GetLength(0), board.GetLength(1));
IGameMode gameMode = new SurvivalMode ();
GameBoard gameBoard = new GameBoard(board, position, gameMode);
gameBoard.PrintBoard(position);
GameRules gamerules = new GameRules();

KeyboardInput input = new KeyboardInput();

while (true)
{
    Console.Clear();
    gamerules.Print();

    gameBoard.PrintBoard(position);

    Console.WriteLine("Använd piltangenterna för att röra dig.");
    Console.WriteLine("Tryck ESC för att avsluta.");

    ConsoleKey key = Console.ReadKey(true).Key;

    if (key == ConsoleKey.Escape)
        break;

    input.HandleInput(key, position, gameBoard);

    
}