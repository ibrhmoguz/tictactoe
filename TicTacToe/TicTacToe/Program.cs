// See https://aka.ms/new-console-template for more information

using TicTacToe;

Console.WriteLine("Noughts and crosses (tic-tac-toe) game");

var player = 1;
var status = false;
var game = new Game();

while (status == false)
{
    game.PrintBoard();
    
    Console.WriteLine($"Player {player}: ");
    Console.WriteLine($"Row: ");
    var rowInput = Console.ReadLine();
    if (!int.TryParse(rowInput, out var row))
    {
        continue;
    }
    
    Console.WriteLine($"Column: ");
    var columnInput = Console.ReadLine();
    if (!int.TryParse(columnInput, out var column))
    {
        continue;
    }
    
    game.Move(row, column);
    status = game.CheckForWin();
    player = player == 1 ? 2 : 1;
    
    Console.WriteLine();
    Console.WriteLine();
}

game.PrintBoard();
Console.WriteLine($"WINNER: Player {player}");

Console.Read();
