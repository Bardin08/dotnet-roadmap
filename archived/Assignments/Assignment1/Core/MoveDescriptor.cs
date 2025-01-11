namespace Assignment1.Core;

internal record MoveDescriptor(
    int Row,
    int Col)
{
    public MoveDescriptor(MoveDescriptor move)
    {
        Row = move.Row;
        Col = move.Col;
    }
}
