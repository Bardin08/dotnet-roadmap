namespace Assignment1;

internal struct PlayerDescriptor
{
    public string Name { get; set; }

    public char Symbol { get; set; }

    public static bool operator ==(PlayerDescriptor lhs, PlayerDescriptor rhs)
    {
        return lhs.Name.Equals(rhs.Name) &&
               lhs.Symbol.Equals(rhs.Symbol);
    }

    public static bool operator !=(PlayerDescriptor lhs, PlayerDescriptor rhs)
    {
        return !(lhs == rhs);
    }

    public override bool Equals(object? obj)
    {
        return obj is PlayerDescriptor other && Equals(other);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Symbol);
    }

    private bool Equals(PlayerDescriptor other)
    {
        return Name == other.Name && Symbol == other.Symbol;
    }
}