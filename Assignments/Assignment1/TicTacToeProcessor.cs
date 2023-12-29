namespace Assignment1;

internal class TicTacToeProcessor(
    PlayersProvider playersProvider,
    UserInputProvider inputProvider)
{
    internal void Process()
    {
        var players = playersProvider.GetPlayers();

        var gameProcessor = new GameProcessor(inputProvider, players);
        var gameResult = gameProcessor.Play();

        Console.WriteLine("Winner: {0}({1})",
            gameResult.Winner.Name,
            gameResult.Winner.Symbol);
    }
}