namespace Assignment1.Core;

internal class TwoPlayersStrategy(
    UserInputProvider inputProvider) : BaseStrategy
{
    public override void DoStep(GameField gameField, PlayerDescriptor player)
    {
        bool isSuccess;
        do
        {
            var move = inputProvider.GetMove(GameField.Size);
            isSuccess = gameField.TrySetSymbol(move.Row, move.Col, player.Symbol);

            if (!isSuccess)
            {
                Console.WriteLine("Input invalid or cell is already taken!");
            }
        } while (!isSuccess);
    }
}