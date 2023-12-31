using Assignment1.Core;

namespace Assignment1.Ai;

internal class AiProcessor(PlayerDescriptor ai)
{
    internal MoveDescriptor GetMove(GameField gameField)
    {
        var bestScore = int.MinValue;
        MoveDescriptor move = null!;
        
        for (int row = 0; row < GameField.Size; row++)
        {
            for (int col = 0; col < GameField.Size; col++)
            {
                if (gameField.TrySetSymbol(row, col, ai.Symbol))
                {
                    var score = Minimax(gameField.DeepCopy(), isMaximizing: false);

                    if (score > bestScore)
                    {
                        move = new MoveDescriptor(row, col);
                        bestScore = score;
                    }
                }
            }
        }

        return move;
    }

    private int Minimax(GameField gameField, bool isMaximizing)
    {
        var score = Evaluate(gameField);

        if (score is 1 or -1)
        {
            return score;
        }

        if (gameField.IsDraw.GetValueOrDefault())
        {
            return 0;
        }

        var baseScore = isMaximizing ? int.MinValue : int.MaxValue;
        Func<int, int, int> scoreEvaluator = isMaximizing ? Math.Max : Math.Min;
        var symbol = isMaximizing ? ai.Symbol : GetOpponentSymbol(ai.Symbol);

        return MinimaxInternal(gameField, isMaximizing, symbol, baseScore, scoreEvaluator);
    }

    private int MinimaxInternal(
        GameField gameField,
        bool isMaximizing,
        char symbol,
        int baseScore,
        Func<int, int, int> scoreEvaluator)
    {
        var best = baseScore;

        for (var row = 0; row < GameField.Size; row++)
        {
            for (var col = 0; col < GameField.Size; col++)
            {
                if (gameField.TrySetSymbol(row, col, symbol))
                {
                    var newScore = Minimax(gameField, !isMaximizing);
                    best = scoreEvaluator(best, newScore);
                    gameField.ForceSetSymbol(row, col, ' ');
                }
            }
        }

        return best;
    }

    private int Evaluate(GameField gameField)
    {
        if (!gameField.IsGameFieldComplete())
        {
            return 0;
        }

        var winner = gameField.GetWinnerSymbol();

        return winner == ai.Symbol ? 1 : -1;
    }

    private char GetOpponentSymbol(char current)
    {
        return current is 'X' ? 'O' : 'X';
    }
}
