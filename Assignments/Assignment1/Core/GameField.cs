using System.Text;
using DeepCopy;

namespace Assignment1.Core;

internal class GameField
{
    public const int Size = 3;

    internal bool? IsDraw { get; private set; }

    private int _movesAmount;

    private readonly List<List<char>> _field = Enumerable.Range(0, Size)
        .Select(_ =>
        {
            return Enumerable.Range(0, Size)
                .Select(_ => ' ')
                .ToList();
        })
        .ToList();

    /// <summary>
    /// <b>DO NOT USE THIS METHOD</b> <br/>
    /// This method is designed to redo the step and used by minimax
    /// evaluation algorithm to avoid cloning boards all the time
    /// </summary>
    internal void ForceSetSymbol(int row, int col, char symbol)
    {
        _field[row][col] = symbol;
        _movesAmount--;
    }

    public bool TrySetSymbol(int row, int col, char symbol)
    {
        if (!IsCellEmpty(row, col))
        {
            return false;
        }

        _field[row][col] = symbol;
        _movesAmount++;
        return true;
    }

    public bool IsGameFieldComplete()
    {
        if (IsWinnerAppeared())
        {
            IsDraw = false;
            return true;
        }

        if (_movesAmount is 9)
        {
            IsDraw = true;
            return true;
        }

        return false;
    }

    internal List<MoveDescriptor> GetAvailableMoves()
    {
        const int maxMoves = Size * Size;
        if (_movesAmount >= maxMoves)
        {
            return [];
        }

        var availableCells = new List<MoveDescriptor>(maxMoves - _movesAmount);

        for (var row = 0; row < Size; row++)
        {
            for (var col = 0; col < Size; col++)
            {
                if (IsCellEmpty(row, col))
                {
                    availableCells.Add(new MoveDescriptor(row, col));
                }
            }
        }

        return availableCells;
    }
    
    internal char? GetWinnerSymbol()
    {
        var allLines = GetRowsAndCols().Concat(GetDiagonals());
        var completedThree = allLines.FirstOrDefault(x => new HashSet<char>(x) is { Count: 1 } set &&
                                                          !set.Contains(' '));
        return completedThree?.First();
    }

    private bool IsWinnerAppeared()
    {
        var allLines = GetRowsAndCols().Concat(GetDiagonals());

        return allLines.Any(x => new HashSet<char>(x) is { Count: 1 } set &&
                                 !set.Contains(' '));
    }

    private bool IsCellEmpty(int row, int col)
    {
        return _field[row][col] is ' ';
    }

    private IEnumerable<IEnumerable<char>> GetRowsAndCols()
    {
        return Enumerable
            .Range(0, Size)
            .Select(col => _field.Select(row => row[col]))
            .Concat(_field);
    }

    private IEnumerable<IEnumerable<char>> GetDiagonals()
    {
        var mainDiagonal = Enumerable.Range(0, _field.Count)
            .Select(i => _field[i][i])
            .ToList();

        var reversedDiagonal = Enumerable.Range(0, _field.Count)
            .Select(i => _field[i][_field.Count - 1 - i])
            .ToList();

        return [mainDiagonal, reversedDiagonal];
    }

    public GameField DeepCopy()
    {
        return DeepCopier.Copy(this);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        for (var row = 0; row < Size; row++)
        {
            for (var col = 0; col < Size; col++)
            {
                sb.Append($" {_field[row][col]} ");
            }

            sb.AppendLine();
        }

        return sb.ToString();
    }
}