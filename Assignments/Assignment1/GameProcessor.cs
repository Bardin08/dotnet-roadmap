namespace Assignment1;

internal class GameProcessor(
    UserInputProvider inputProvider,
    (PlayerDescriptor p1, PlayerDescriptor p2) players)
{
    private PlayerDescriptor _currentPlayer = players.p2;

    // TODO: Replace object with actual game result
    internal GameResult Play()
    {
        var gameField = new GameField();
        while (!gameField.IsGameFieldComplete())
        {   
            _currentPlayer = _currentPlayer == players.p1 ? players.p2 : players.p1;

            MoveDescriptor? move;
            do
            {
                move = inputProvider.GetMove(GameField.Size);

                if (!gameField.IsEmpty(move.Row, move.Col))
                {
                    Console.WriteLine("Cell is not empty! Choose another one!");
                }
            } while (!gameField.IsEmpty(move.Row, move.Col));

            gameField.SetSymbol(move.Row, move.Col, _currentPlayer.Symbol);
            Console.WriteLine(gameField);
        }

        return new GameResult(_currentPlayer);
    }
}