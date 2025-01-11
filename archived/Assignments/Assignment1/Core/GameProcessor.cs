namespace Assignment1.Core;

internal class GameProcessor(
    UserInputProvider inputProvider,
    (PlayerDescriptor p1, PlayerDescriptor p2) players,
    GameMode mode)
{
    private PlayerDescriptor _currentPlayer = players.p2;

    internal GameResult Play()
    {
        IGameStrategy gameStrategy = mode is GameMode.TwoPlayers
            ? new TwoPlayersStrategy(inputProvider)
            : new AiOpponentStrategy(inputProvider);

        var gameField = new GameField();
        while (!gameField.IsGameFieldComplete())
        {
            _currentPlayer = _currentPlayer == players.p1 ? players.p2 : players.p1;

            gameStrategy.DoStep(gameField, _currentPlayer);

            Console.WriteLine(gameField);
        }

        var gameResult = gameField.IsDraw.GetValueOrDefault()
            ? new GameResult()
            : new GameResult(_currentPlayer);

        return gameResult;
    }
}