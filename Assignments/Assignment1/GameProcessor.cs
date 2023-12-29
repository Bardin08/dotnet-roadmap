namespace Assignment1;

internal class GameProcessor(
    UserInputProvider inputProvider,
    (PlayerDescriptor p1, PlayerDescriptor p2) players)
{
    private PlayerDescriptor _currentPlayer = players.p2;

    internal GameResult Play()
    {
        var gameField = new GameField();
        while (!gameField.IsGameFieldComplete())
        {   
            _currentPlayer = _currentPlayer == players.p1 ? players.p2 : players.p1;

            DoStep(gameField);

            Console.WriteLine(gameField);
        }

        return new GameResult(_currentPlayer);
    }

    private void DoStep(GameField gameField)
    {
        bool isSuccess;
        do
        {
            var move = inputProvider.GetMove(GameField.Size);
            isSuccess = gameField.TrySetSymbol(move.Row, move.Col, _currentPlayer.Symbol);

            if (!isSuccess)
            {
                Console.WriteLine("Input invalid or cell is already taken!");
            }
        } while (!isSuccess);
    }
}