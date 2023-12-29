using System.Text;

namespace Assignment1;

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
            return true;
        }

        if (_movesAmount is 9)
        {
            IsDraw = true;
            return true;
        }

        return false;
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