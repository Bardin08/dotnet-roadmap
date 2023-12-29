namespace Assignment1;

internal readonly record struct PlayerDescriptor(string Name, char Symbol)
{
    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Symbol);
    }
}