using TicTacToeOO;

var board = new Board();
var gameConsole = new GameConsole(board);
while (true)
{
    gameConsole.Show();
    Console.Write("Skriv inn hvor du vil sette kryss (f.eks. \"a2\"): ");
    var position = Console.ReadLine();
    board.Mark(position);
    gameConsole.Show();
    Thread.Sleep(2000);
    board.MarkRandom(false);
}