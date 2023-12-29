namespace Assignment1.Core;

internal readonly record struct PlayerDescriptor(string Name, char Symbol)
{
    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Symbol);
    }
}