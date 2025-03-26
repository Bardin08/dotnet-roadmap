using Assignment1.Core;

namespace Assignment1.Ai;

internal class AiProcessor(PlayerDescriptor ai)
{
    private readonly char _aiSymbol = ai.Symbol;
    private readonly char _opponentSymbol = ai.Symbol == 'O' ? 'X' : 'O';

    internal MoveDescriptor GetMove(GameField gameField)
    {
        MoveDescriptor move = null!;
        var score = int.MinValue;
        var availableMoves = gameField.GetAvailableMoves();

        foreach (var availableMove in availableMoves)
        {
            if (!gameField.TrySetSymbol(availableMove.Row, availableMove.Col, _aiSymbol))
                continue;

            var newScore = Minimax(gameField, false, 0);
            gameField.ForceSetSymbol(availableMove.Row, availableMove.Col, ' ');

            if (newScore > score)
            {
                score = newScore;
                move = new MoveDescriptor(availableMove);
            }
        }

        return move;
    }

    private int Minimax(GameField gameField, bool isMaximizing, int depth)
    {
        if (gameField.IsGameFieldComplete())
            return Evaluate(gameField, depth);

        if (isMaximizing)
        {
            var score = int.MinValue;

            foreach (var availableMove in gameField.GetAvailableMoves())
            {
                if (gameField.TrySetSymbol(availableMove.Row, availableMove.Col, _aiSymbol))
                {
                    score = Math.Max(score, Minimax(gameField, false, depth + 1));
                    gameField.ForceSetSymbol(availableMove.Row, availableMove.Col, ' ');
                }
            }

            return score;
        }
        else
        {
            var score = int.MaxValue;

            foreach (var availableMove in gameField.GetAvailableMoves())
            {
                if (gameField.TrySetSymbol(availableMove.Row, availableMove.Col, _opponentSymbol))
                {
                    score = Math.Min(score, Minimax(gameField, true, depth + 1));
                    gameField.ForceSetSymbol(availableMove.Row, availableMove.Col, ' ');
                }
            }

            return score;
        }
    }

    private int Evaluate(GameField gameField, int depth)
    {
        if (!gameField.IsGameFieldComplete())
        {
            throw new ArgumentException("Uncompleted board can't be evaluated");
        }

        var winner = gameField.GetWinnerSymbol();
        if (winner == _aiSymbol)
            return 10 - depth;

        if (winner == _opponentSymbol)
            return -10 + depth;

        return 0;
    }
}
