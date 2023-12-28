﻿using System.Text;

namespace Assignment1;

internal class GameField
{
    public const int Size = 3;

    private int _movesAmount;
    private readonly List<List<char>> _field;

    public GameField()
    {
        _field =
        [
            [' ', ' ', ' '],
            [' ', ' ', ' '],
            [' ', ' ', ' ']
        ];

        for (var row = 0; row < Size; row++)
        {
            for (var col = 0; col < Size; col++)
            {
                _field[row][col] = ' ';
            }
        }
    }

    public void SetSymbol(int row, int col, char symbol)
    {
        _field[row][col] = symbol;
        _movesAmount++;
    }

    public bool IsEmpty(int row, int col)
    {
        return _field[row][col] is ' ';
    }

    public bool IsGameFieldComplete()
    {
        if (_movesAmount is 9)
        {
            return true;
        }

        var allLines = GetRowsAndCols().Concat(GetDiagonals());
        return allLines.Any(x => new HashSet<char>(x) is { Count: 1 } set &&
                                 !set.Contains(' '));
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