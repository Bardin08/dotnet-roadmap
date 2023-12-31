using Assignment1.Core;

namespace Assignment1.Ai;

internal class AiProcessor(PlayerDescriptor ai)
{
    internal MoveDescriptor GetMove(GameField gameField)
    {
        var bestScore = int.MinValue;
        MoveDescriptor move = null!;

        for (var row = 0; row < GameField.Size; row++)
        {
            for (var col = 0; col < GameField.Size; col++)
            {
                var field = gameField.DeepCopy();
                if (field.TrySetSymbol(row, col, ai.Symbol))
                {
                    var score = Minimax(field, 0, isMaximizing: false);
                    field.ForceSetSymbol(row, col, ' ');       
                    
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

    private int Minimax(GameField gameField, int depth, bool isMaximizing)
    {
        var score = Evaluate(gameField);

        var winnerSymbol = gameField.GetWinnerSymbol();
        if (winnerSymbol == ai.Symbol)
        {
            return 10 - depth;
        }
        else if (winnerSymbol == GetOpponentSymbol(ai.Symbol))
        {
            return depth - 10;
        }

        if (gameField.IsDraw.GetValueOrDefault())
        {
            return 0;
        }

        return MinimaxInternal(gameField, depth, isMaximizing);
    }

    private int MinimaxInternal(
        GameField gameField,
        int depth,
        bool isMaximizing)
    {
        var best = isMaximizing ? int.MinValue : int.MaxValue;
        var symbol = isMaximizing ? ai.Symbol : GetOpponentSymbol(ai.Symbol);

        for (var row = 0; row < GameField.Size; row++)
        {
            for (var col = 0; col < GameField.Size; col++)
            {
                if (gameField.TrySetSymbol(row, col, symbol))
                {
                    var newScore = Minimax(gameField, depth + 1, !isMaximizing);
                    best = isMaximizing ? Math.Max(best, newScore) : Math.Min(best, newScore);
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

        return winner == ai.Symbol ? 10 : -10;
    }

    private char GetOpponentSymbol(char current)
    {
        return current is 'X' ? 'O' : 'X';
    }
}
