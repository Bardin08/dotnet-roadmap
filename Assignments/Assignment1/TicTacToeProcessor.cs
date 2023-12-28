namespace Assignment1;

internal class TicTacToeProcessor(
    PlayersProvider playersProvider,
    UserInputProvider inputProvider)
{
    internal void Process()
    {
        var players = playersProvider.GetPlayers();

        Console.WriteLine(players.p1.Name + " " + players.p1.Symbol);
        Console.WriteLine(players.p2.Name + " " + players.p2.Symbol);

        var gameProcessor = new GameProcessor(inputProvider, players);
        var gameResult = gameProcessor.Play();

        Console.WriteLine("Winner: {0}({1})",
            gameResult.Winner.Name,
            gameResult.Winner.Symbol);
    }
}