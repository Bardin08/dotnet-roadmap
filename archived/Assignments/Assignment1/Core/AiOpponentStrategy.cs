using Assignment1.Ai;

namespace Assignment1.Core;

internal class AiOpponentStrategy(UserInputProvider inputProvider) : BaseStrategy
{
    private AiProcessor? _aiProcessor;

    public override void DoStep(GameField gameField, PlayerDescriptor player)
    {
        bool isSuccess;
        do
        {
            MoveDescriptor? move;

            if (player.IsAi)
            {
                _aiProcessor ??= new AiProcessor(player);
                move = _aiProcessor.GetMove(gameField);
            }
            else
            {
                move = inputProvider.GetMove(GameField.Size);
            }

            isSuccess = gameField.TrySetSymbol(move.Row, move.Col, player.Symbol);

            if (!isSuccess)
            {
                Console.WriteLine("Input invalid or cell is already taken!");
            }
        } while (!isSuccess);
    }
}