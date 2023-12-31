namespace Assignment1.Core;

internal record class PlayerDescriptor(string Name = "", char Symbol = ' ', bool IsAi = false)
{
    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Symbol);
    }
}